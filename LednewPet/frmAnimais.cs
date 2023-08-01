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
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        private void frmAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.racas'. Você pode movê-la ou removê-la conforme necessário.
            this.racasTableAdapter.Fill(this.petshopDataSet.racas);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.petshopDataSet.clientes);
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.animais'. Você pode movê-la ou removê-la conforme necessário.
            this.animaisTableAdapter.Fill(this.petshopDataSet.animais);

        }

        private void animaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void ani_corLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_agressivoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_alergiaLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_racaLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ani_fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ani_codigoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
