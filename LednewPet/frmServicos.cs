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
    public partial class frmServicos : Form
    {
        public frmServicos()
        {
            InitializeComponent();
        }

        private void servicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // tratamento de exceção caso algum dado de cadastro não seja preenchido corretamente
            try
            {
                this.Validate();
                this.servicosBindingSource.EndEdit();
                servicosTableAdapter.Update(petshopDataSet.servicos);
                groupBox1.Enabled = false;
                MessageBox.Show("Cadastro efetuado com sucesso!", "UNIPET, seu pet, nossa família!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os dados inseridos e tente novamente.", "UNIPET, seu pet, nossa família!");

            }
        }

            private void frmServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.petshopDataSet.servicos);

        }

        private void BtnCancelarServicos_Click(object sender, EventArgs e)
        {
            servicosBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este cadastro?", "UNIPET, seu pet, nossa família!",// confirmando exclusão com o usuário  
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
                {
                    servicosBindingSource.RemoveCurrent();// exclusão do registro
                    servicosTableAdapter.Update(petshopDataSet.servicos);// banco de dados atualizado
                }

            }
            catch (Exception)
            {
                servicosTableAdapter.Fill(petshopDataSet.servicos);
                MessageBox.Show("Registro não pode ser excluído!", "UNIPET, seu pet, nossa família!");// excessão por causa de dados compartilhados
            }
                MessageBox.Show("Cadastro excluído com sucesso!!", "UNIPET, seu pet, nossa família!");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void BtnEditarServicos_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
