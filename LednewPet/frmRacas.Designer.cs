namespace LednewPet
{
    partial class frmRacas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label raca_codigoLabel;
            System.Windows.Forms.Label raca_nomeLabel;
            System.Windows.Forms.Label raca_pais_origemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRacas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raca_codigoLabel1 = new System.Windows.Forms.Label();
            this.racasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new LednewPet.petshopDataSet();
            this.raca_nomeTextBox = new System.Windows.Forms.TextBox();
            this.raca_pais_origemTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.racasTableAdapter = new LednewPet.petshopDataSetTableAdapters.racasTableAdapter();
            this.tableAdapterManager = new LednewPet.petshopDataSetTableAdapters.TableAdapterManager();
            this.racasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.racasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            raca_codigoLabel = new System.Windows.Forms.Label();
            raca_nomeLabel = new System.Windows.Forms.Label();
            raca_pais_origemLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingNavigator)).BeginInit();
            this.racasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // raca_codigoLabel
            // 
            raca_codigoLabel.AutoSize = true;
            raca_codigoLabel.Location = new System.Drawing.Point(36, 81);
            raca_codigoLabel.Name = "raca_codigoLabel";
            raca_codigoLabel.Size = new System.Drawing.Size(207, 30);
            raca_codigoLabel.TabIndex = 0;
            raca_codigoLabel.Text = "código da raça:";
            // 
            // raca_nomeLabel
            // 
            raca_nomeLabel.AutoSize = true;
            raca_nomeLabel.Location = new System.Drawing.Point(36, 145);
            raca_nomeLabel.Name = "raca_nomeLabel";
            raca_nomeLabel.Size = new System.Drawing.Size(192, 30);
            raca_nomeLabel.TabIndex = 2;
            raca_nomeLabel.Text = "nome da raça:";
            // 
            // raca_pais_origemLabel
            // 
            raca_pais_origemLabel.AutoSize = true;
            raca_pais_origemLabel.Location = new System.Drawing.Point(36, 200);
            raca_pais_origemLabel.Name = "raca_pais_origemLabel";
            raca_pais_origemLabel.Size = new System.Drawing.Size(199, 30);
            raca_pais_origemLabel.TabIndex = 4;
            raca_pais_origemLabel.Text = "país de origem:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(raca_codigoLabel);
            this.groupBox1.Controls.Add(this.raca_codigoLabel1);
            this.groupBox1.Controls.Add(raca_nomeLabel);
            this.groupBox1.Controls.Add(this.raca_nomeTextBox);
            this.groupBox1.Controls.Add(raca_pais_origemLabel);
            this.groupBox1.Controls.Add(this.raca_pais_origemTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(283, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Raça do Pet";
            // 
            // raca_codigoLabel1
            // 
            this.raca_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racasBindingSource, "raca_codigo", true));
            this.raca_codigoLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_codigoLabel1.Location = new System.Drawing.Point(264, 86);
            this.raca_codigoLabel1.Name = "raca_codigoLabel1";
            this.raca_codigoLabel1.Size = new System.Drawing.Size(168, 30);
            this.raca_codigoLabel1.TabIndex = 1;
            this.raca_codigoLabel1.Text = "label1";
            // 
            // racasBindingSource
            // 
            this.racasBindingSource.DataMember = "racas";
            this.racasBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raca_nomeTextBox
            // 
            this.raca_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racasBindingSource, "raca_nome", true));
            this.raca_nomeTextBox.Location = new System.Drawing.Point(264, 138);
            this.raca_nomeTextBox.Name = "raca_nomeTextBox";
            this.raca_nomeTextBox.Size = new System.Drawing.Size(168, 37);
            this.raca_nomeTextBox.TabIndex = 3;
            // 
            // raca_pais_origemTextBox
            // 
            this.raca_pais_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racasBindingSource, "raca_pais_origem", true));
            this.raca_pais_origemTextBox.Location = new System.Drawing.Point(264, 193);
            this.raca_pais_origemTextBox.Name = "raca_pais_origemTextBox";
            this.raca_pais_origemTextBox.Size = new System.Drawing.Size(168, 37);
            this.raca_pais_origemTextBox.TabIndex = 5;
            // 
            // racasTableAdapter
            // 
            this.racasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamentos_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentosTableAdapter = null;
            this.tableAdapterManager.animaisTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.racasTableAdapter = this.racasTableAdapter;
            this.tableAdapterManager.servicosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LednewPet.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // racasBindingNavigator
            // 
            this.racasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.racasBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.racasBindingNavigator.BindingSource = this.racasBindingSource;
            this.racasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.racasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.racasBindingNavigator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racasBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.racasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.racasBindingNavigatorSaveItem,
            this.BtnCancelar,
            this.BtnEditar});
            this.racasBindingNavigator.Location = new System.Drawing.Point(445, 44);
            this.racasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racasBindingNavigator.Name = "racasBindingNavigator";
            this.racasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racasBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.racasBindingNavigator.Size = new System.Drawing.Size(564, 39);
            this.racasBindingNavigator.TabIndex = 1;
            this.racasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // racasBindingNavigatorSaveItem
            // 
            this.racasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("racasBindingNavigatorSaveItem.Image")));
            this.racasBindingNavigatorSaveItem.Name = "racasBindingNavigatorSaveItem";
            this.racasBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.racasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.racasBindingNavigatorSaveItem.Click += new System.EventHandler(this.racasBindingNavigatorSaveItem_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(104, 36);
            this.BtnCancelar.Text = "Cancelar";
            // 
            // BtnEditar
            // 
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(81, 36);
            this.BtnEditar.Text = "Editar";
            // 
            // frmRacas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.racasBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRacas";
            this.Text = "frmRacas";
            this.Load += new System.EventHandler(this.frmRacas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racasBindingNavigator)).EndInit();
            this.racasBindingNavigator.ResumeLayout(false);
            this.racasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource racasBindingSource;
        private petshopDataSetTableAdapters.racasTableAdapter racasTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton racasBindingNavigatorSaveItem;
        private System.Windows.Forms.Label raca_codigoLabel1;
        private System.Windows.Forms.TextBox raca_nomeTextBox;
        private System.Windows.Forms.TextBox raca_pais_origemTextBox;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnEditar;
    }
}