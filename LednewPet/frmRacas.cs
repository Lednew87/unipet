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

        private void racasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void racasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.racasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void frmRacas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.racas'. Você pode movê-la ou removê-la conforme necessário.
            this.racasTableAdapter.Fill(this.petshopDataSet.racas);

        }

    }
}
