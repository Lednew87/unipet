using LednewPet.petshopDataSetTableAdapters;
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
            // tratamento de exceção caso algum dado de cadastro não seja preenchido corretamente
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                clientesTableAdapter.Update(petshopDataSet.clientes);
                groupBox1.Enabled = false;
                MessageBox.Show("Cadastro efetuado com sucesso!", "UNIPET, seu pet, nossa família!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os dados inseridos e tente novamente.", "UNIPET, seu pet, nossa família!");
 
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.CancelEdit();
            groupBox1.Enabled=false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este cadastro?", "UNIPET, seu pet, nossa família!",// confirmando exclusão com o usuário  
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    _ = MessageBox.Show("Cadastro excluído com sucesso!!", "UNIPET, seu pet, nossa família!");
                {
                    clientesBindingSource.RemoveCurrent();// exclusão do registro
                    clientesTableAdapter.Update(petshopDataSet.clientes);// banco de dados atualizado

                }

            }
            catch (Exception)
            {
                clientesTableAdapter.Fill(petshopDataSet.clientes);
                MessageBox.Show("Registro não pode ser excluído!", "UNIPET, seu pet, nossa família!");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cli_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cli_nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_celularMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cli_emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_cpfMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cli_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cli_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void clientesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cli_codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_cpfLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_celularLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void cli_nomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}