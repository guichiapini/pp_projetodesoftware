using System;
using System.Windows.Forms;
using System.Drawing;

namespace NextTaskWindowsForms
{
    public partial class MainScreen : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblHeader = new Label();
            subtitle = new Label();
            dgvTasks = new DataGridView();
            lblID = new Label();
            txtID = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnNewTask = new Button();
            btnEditTask = new Button();
            btnDeleteTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // titulo: NEXTASK
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(30, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(171, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "NexTask";
            // 
            // SUBTITULO: MENSAGEM
            // 
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            subtitle.ForeColor = Color.LightGray;
            subtitle.Location = new Point(207, 43);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(223, 21);
            subtitle.TabIndex = 1;
            subtitle.Text = "Gerencie suas metas diárias.";
            // 
            // TABELA DE TAREFAS
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToResizeRows = false;
            dgvTasks.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(60, 60, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 255, 198);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTasks.EnableHeadersVisualStyles = false;
            dgvTasks.GridColor = Color.Gray;
            dgvTasks.Location = new Point(30, 102);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(801, 358);
            dgvTasks.TabIndex = 4;
            // 
            // LABEL ID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(30, 530);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 19);
            lblID.TabIndex = 5;
            lblID.Text = "ID:";
            // 
            // CAMPO ID
            // 
            txtID.BackColor = Color.FromArgb(60, 60, 60);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(127, 528);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 25);
            txtID.TabIndex = 6;
            // 
            // LABEL TITULO
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 565);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 19);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Título:";
            // 
            // CAMPO TITULO
            // 
            txtTitle.BackColor = Color.FromArgb(60, 60, 60);
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(127, 565);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(291, 25);
            txtTitle.TabIndex = 8;
            // 
            // LABEL DESCRICAO
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(30, 604);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 19);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Descrição:";
            // 
            // CAMPO DESCRICAO
            // 
            txtDescription.BackColor = Color.FromArgb(60, 60, 60);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(127, 602);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(704, 25);
            txtDescription.TabIndex = 10;
            // 
            // LABEL DE DATA DE VENCIMENTO
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(512, 565);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(91, 19);
            lblDueDate.TabIndex = 11;
            lblDueDate.Text = "Vencimento:";
            // 
            // PICKER DE DATA DE VENCIMENTO
            // 
            dtpDueDate.CalendarForeColor = Color.Black;
            dtpDueDate.CalendarMonthBackground = Color.White;
            dtpDueDate.Font = new Font("Segoe UI", 10F);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(635, 565);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(196, 25);
            dtpDueDate.TabIndex = 12;
            // 
            // LABEL STATUS
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(550, 534);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 19);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            // 
            // COMBOBOX STATUS
            // 
            cmbStatus.BackColor = Color.FromArgb(60, 60, 60);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.ForeColor = Color.White;
            cmbStatus.Items.AddRange(new object[] { "Pendente", "Em Andamento", "Concluída" });
            cmbStatus.Location = new Point(635, 530);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(196, 25);
            cmbStatus.TabIndex = 14;
            // 
            // BOTÃO NOVA TAREFA
            // 
            btnNewTask.BackColor = Color.FromArgb(0, 255, 198);
            btnNewTask.FlatAppearance.BorderColor = Color.Gray;
            btnNewTask.FlatStyle = FlatStyle.Flat;
            btnNewTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewTask.ForeColor = Color.Black;
            btnNewTask.Location = new Point(30, 684);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(230, 45);
            btnNewTask.TabIndex = 5;
            btnNewTask.Text = "Nova Tarefa";
            btnNewTask.UseVisualStyleBackColor = false;
            // 
            // BOTÃO EDITAR
            // 
            btnEditTask.BackColor = Color.FromArgb(255, 223, 100);
            btnEditTask.FlatAppearance.BorderColor = Color.Gray;
            btnEditTask.FlatStyle = FlatStyle.Flat;
            btnEditTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditTask.ForeColor = Color.Black;
            btnEditTask.Location = new Point(317, 684);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(230, 45);
            btnEditTask.TabIndex = 6;
            btnEditTask.Text = "Editar";
            btnEditTask.UseVisualStyleBackColor = false;
            // 
            // BOTÃO DELETAR
            // 
            btnDeleteTask.BackColor = Color.FromArgb(255, 110, 110);
            btnDeleteTask.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteTask.ForeColor = Color.Black;
            btnDeleteTask.Location = new Point(601, 684);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(230, 45);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Deletar";
            btnDeleteTask.UseVisualStyleBackColor = false;
            // 
            // TELA PRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(858, 753);
            Controls.Add(lblHeader);
            Controls.Add(subtitle);
            Controls.Add(dgvTasks);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblDueDate);
            Controls.Add(dtpDueDate);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnNewTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnDeleteTask);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexTask";
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblHeader;
        private Label subtitle;
        private DataGridView dgvTasks;
        private Label lblID;
        private TextBox txtID;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnNewTask;
        private Button btnEditTask;
        private Button btnDeleteTask;
    }
}
