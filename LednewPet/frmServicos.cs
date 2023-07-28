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
            this.Validate();
            this.servicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.petshopDataSet);

        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'petshopDataSet.servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.servicosTableAdapter.Fill(this.petshopDataSet.servicos);

        }
    }
}
