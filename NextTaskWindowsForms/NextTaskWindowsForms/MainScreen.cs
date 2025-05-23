using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NextTaskWindowsForms
{
    public partial class MainScreen : Form
    {
        private List<TaskItem> taskList = new List<TaskItem>();
        private int nextId = 1;

        public MainScreen()
        {
            InitializeComponent();

            // Associando eventos aos botões
            btnNewTask.Click += BtnNewTask_Click;
            btnEditTask.Click += BtnEditTask_Click;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            dgvTasks.CellClick += DgvTasks_CellClick;

            // Configurando colunas da tabela
            dgvTasks.Columns.Add("ID", "ID");
            dgvTasks.Columns.Add("Title", "Título");
            dgvTasks.Columns.Add("Description", "Descrição");
            dgvTasks.Columns.Add("DueDate", "Vencimento");
            dgvTasks.Columns.Add("Status", "Status");
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o título e selecione o status.");
                return;
            }

            var task = new TaskItem
            {
                Id = nextId++,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DueDate = dtpDueDate.Value.Date,
                Status = cmbStatus.SelectedItem.ToString()
            };

            taskList.Add(task);
            RefreshTable();
            ClearFields();
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                var task = taskList.Find(t => t.Id == id);
                if (task != null)
                {
                    task.Title = txtTitle.Text;
                    task.Description = txtDescription.Text;
                    task.DueDate = dtpDueDate.Value.Date;
                    task.Status = cmbStatus.SelectedItem?.ToString() ?? "Pendente";
                    RefreshTable();
                    ClearFields();
                }
            }
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                taskList.RemoveAll(t => t.Id == id);
                RefreshTable();
                ClearFields();
            }
        }

        private void DgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTasks.Rows.Count)
            {
                var row = dgvTasks.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                dtpDueDate.Value = DateTime.TryParse(row.Cells["DueDate"].Value.ToString(), out var date) ? date : DateTime.Now;
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void RefreshTable()
        {
            dgvTasks.Rows.Clear();
            foreach (var task in taskList)
            {
                dgvTasks.Rows.Add(task.Id, task.Title, task.Description, task.DueDate.ToShortDateString(), task.Status);
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtTitle.Clear();
            txtDescription.Clear();
            dtpDueDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
        }
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
