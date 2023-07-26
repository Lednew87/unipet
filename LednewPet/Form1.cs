using System;
using System.Windows.Forms;

namespace LednewPet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLeft_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // btn fechar
            if (MessageBox.Show("Deseja mesmo sair?", "UNIPET seu pet, nossa família!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // instaciando btn clientes 
            frmCadClientes clientes = new frmCadClientes();
            clientes.TopLevel = false; // hierarquia do form
            clientes.Dock = DockStyle.Fill; // dimensão do form
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(clientes); // add o form de cadastro de clientes
            clientes.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = btnClientes.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            PanelSelect.Top = btnHome.Top;
        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelRight_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnRacas_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = btnRacas.Top;
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = btnAnimais.Top;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = btnServicos.Top;
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            PanelSelect.Top = btnAgendamentos.Top;
        }
    }
}
