using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LednewPet
{
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                clientesTableAdapter.Update(petshopDataSet.clientes);
                groupBox1.Enabled = false;
                MessageBox.Show("Cadastro efetuado com sucesso!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os dados inseridos e tente novamente.");

              
            }

        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            groupBox1.Enabled = true;
        }
    }
}