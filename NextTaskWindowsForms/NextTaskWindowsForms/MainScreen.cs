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

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new task!"); // MÉTOODO RESPONSÁVEL POR CRIAR NOVA TAREFA DE ACORDO COM DADOS INSERIDOS PELO USUARIO
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit a task!"); // MÉTOODO RESPONSÁVEL POR EDITAR A TAREFA SELECIONADA
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete a task!"); // MÉTOODO RESPONSÁVEL POR DELETAR A TAREFA SELECIONADA
        }

        private void DgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Content Cell clicked!"); // MÉTODO CHAMADO QUANDO SELECIONADO A TAREFA NO DATA GRID VIEW (TABELA)
        }
    }
}
