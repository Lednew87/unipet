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
    public partial class frmRacas : Form
    {
        public frmRacas()
        {
            InitializeComponent();
        }

        private void racasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            // tratamento de exceção caso algum dado de cadastro não seja preenchido corretamente
            try
            {
                this.Validate();
                this.racasBindingSource.EndEdit();
                racasTableAdapter.Update(petshopDataSet.racas);
                groupBox1.Enabled = false;
                MessageBox.Show("Cadastro efetuado com sucesso!", "UNIPET, seu pet, nossa família!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro, verifique os dados inseridos e tente novamente.", "UNIPET, seu pet, nossa família!");

            }

        }

        private void frmRacas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.racas'. Você pode movê-la ou removê-la conforme necessário.
            this.racasTableAdapter.Fill(this.petshopDataSet.racas);

        }

        private void BtnCancelarRaca_Click(object sender, EventArgs e)
        {
            racasBindingSource.CancelEdit();
            groupBox1.Enabled = false;
        }

        private void BtnEditarRaca_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir este cadastro?", "UNIPET, seu pet, nossa família!",// confirmando exclusão com o usuário  
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                
                {
                    racasBindingSource.RemoveCurrent();// exclusão do registro
                    racasTableAdapter.Update(petshopDataSet.racas);// banco de dados atualizado

                }

            }
            catch (Exception)
            {
                racasTableAdapter.Fill(petshopDataSet.racas);
                MessageBox.Show("Registro não pode ser excluído!", "UNIPET, seu pet, nossa família!");
            }
                MessageBox.Show("Cadastro excluído com sucesso!!", "UNIPET, seu pet, nossa família!");
        }
    }
}
