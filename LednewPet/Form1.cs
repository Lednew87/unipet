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
        private void Label1_Paint(object sender, EventArgs e)
        {

        }
        private void Label2_Paint(object sender, EventArgs e)
        {

        }
        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // btn fechar
            if (MessageBox.Show("Deseja mesmo sair?", "UNIPET seu pet, nossa família!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //btn minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            // instaciando btnClientes
            frmCadClientes frmCadClientes = new frmCadClientes
            {
                TopLevel = false, // hierarquia do form
                Dock = DockStyle.Fill // dimensão do form
            };
            frmCadClientes clientes = frmCadClientes;
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(clientes); // add o form de cadastro de clientes
            clientes.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = BtnClientes.Top;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            PanelCenter.Controls.Add(LabelLogoLeft);
            PanelCenter.Controls.Add(LabelLogoRight);
            PanelSelect.Top = BtnHome.Top;
        }


        private void BtnRacas_Click(object sender, EventArgs e)
        {
            // instaciando btnRacas 
            frmRacas racas = new frmRacas();
            racas.TopLevel = false; // hierarquia do form
            racas.Dock = DockStyle.Fill; // dimensão do form
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(racas); // add o form de cadastro de raças
            racas.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = BtnRacas.Top;
        }

        private void BtnAnimais_Click(object sender, EventArgs e)
        {
            // instaciando btnAnimais
            frmAnimais animais = new frmAnimais();
            animais.TopLevel = false; // hierarquia do form
            animais.Dock = DockStyle.Fill; // dimensão do form
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(animais); // add o form de cadastro de animais
            animais.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = BtnAnimais.Top;
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            // instaciando btnServicos
            frmServicos servicos = new frmServicos();
            servicos.TopLevel = false; // hierarquia do form
            servicos.Dock = DockStyle.Fill; // dimensão do form
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(servicos); // add o form de cadastro de serviços
            servicos.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = BtnServicos.Top;
        }

        private void BtnAgendamentos_Click(object sender, EventArgs e)
        {
            // instaciando btnAgendamentos 
            frmAgendamentos agendamentos = new frmAgendamentos();
            agendamentos.TopLevel = false; // hierarquia do form
            agendamentos.Dock = DockStyle.Fill; // dimensão do form
            PanelCenter.Controls.Clear(); // limpa o painel
            PanelCenter.Controls.Add(agendamentos); // add o form de cadastro de agendamentos
            agendamentos.Show();

            // aplicando a posição do eixo X do PanelSelect nos botões selecionados
            PanelSelect.Top = BtnAgendamentos.Top;
        }
        
    }
}
