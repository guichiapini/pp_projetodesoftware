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
            btnNewTask = new Button();
            btnEditTask = new Button();
            btnDeleteTask = new Button();
            dgvTasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
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
            // subtitle
            // 
            subtitle.AutoSize = true;
            subtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            subtitle.ForeColor = Color.LightGray;
            subtitle.Location = new Point(35, 80);
            subtitle.Name = "subtitle";
            subtitle.Size = new Size(223, 21);
            subtitle.TabIndex = 1;
            subtitle.Text = "Gerencie suas metas diárias.";
            // 
            // btnNewTask
            // 
            btnNewTask.BackColor = Color.FromArgb(0, 255, 198);
            btnNewTask.FlatAppearance.BorderColor = Color.Gray;
            btnNewTask.FlatStyle = FlatStyle.Flat;
            btnNewTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNewTask.ForeColor = Color.Black;
            btnNewTask.Location = new Point(30, 510);
            btnNewTask.Name = "btnNewTask";
            btnNewTask.Size = new Size(230, 45);
            btnNewTask.TabIndex = 5;
            btnNewTask.Text = "Nova Tarefa";
            btnNewTask.UseVisualStyleBackColor = false;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.FromArgb(255, 223, 100);
            btnEditTask.FlatAppearance.BorderColor = Color.Gray;
            btnEditTask.FlatStyle = FlatStyle.Flat;
            btnEditTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditTask.ForeColor = Color.Black;
            btnEditTask.Location = new Point(290, 510);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(230, 45);
            btnEditTask.TabIndex = 6;
            btnEditTask.Text = "Editar";
            btnEditTask.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.FromArgb(255, 110, 110);
            btnDeleteTask.FlatAppearance.BorderColor = Color.Gray;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteTask.ForeColor = Color.Black;
            btnDeleteTask.Location = new Point(550, 510);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(230, 45);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Deletar";
            btnDeleteTask.UseVisualStyleBackColor = false;
            // 
            // dgvTasks
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
            dgvTasks.Location = new Point(30, 120);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(750, 370);
            dgvTasks.TabIndex = 4;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(820, 580);
            Controls.Add(lblHeader);
            Controls.Add(subtitle);
            Controls.Add(dgvTasks);
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
        private Button btnNewTask;
        private Button btnEditTask;
        private Button btnDeleteTask;
        private DataGridView dgvTasks;
    }
}
