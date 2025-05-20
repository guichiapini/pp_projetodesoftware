using System;
using System.Windows.Forms;

namespace NextTaskWindowsForms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit a task!");
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new task!");
        }


        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete a task!");
        }

        private void DgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Content Cell clicked!");
        }
    }
}
