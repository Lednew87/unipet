namespace LednewPet
{
    partial class frmServicos
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
            System.Windows.Forms.Label serv_codigoLabel;
            System.Windows.Forms.Label serv_descricaoLabel;
            System.Windows.Forms.Label serv_precoLabel;
            System.Windows.Forms.Label serv_tempoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serv_codigoLabel1 = new System.Windows.Forms.Label();
            this.servicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new LednewPet.petshopDataSet();
            this.serv_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.serv_precoTextBox = new System.Windows.Forms.TextBox();
            this.serv_tempoTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.servicosTableAdapter = new LednewPet.petshopDataSetTableAdapters.servicosTableAdapter();
            this.tableAdapterManager = new LednewPet.petshopDataSetTableAdapters.TableAdapterManager();
            this.servicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            serv_codigoLabel = new System.Windows.Forms.Label();
            serv_descricaoLabel = new System.Windows.Forms.Label();
            serv_precoLabel = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingNavigator)).BeginInit();
            this.servicosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serv_codigoLabel
            // 
            serv_codigoLabel.AutoSize = true;
            serv_codigoLabel.Location = new System.Drawing.Point(31, 96);
            serv_codigoLabel.Name = "serv_codigoLabel";
            serv_codigoLabel.Size = new System.Drawing.Size(238, 30);
            serv_codigoLabel.TabIndex = 0;
            serv_codigoLabel.Text = "código do serviço:";
            // 
            // serv_descricaoLabel
            // 
            serv_descricaoLabel.AutoSize = true;
            serv_descricaoLabel.Location = new System.Drawing.Point(31, 156);
            serv_descricaoLabel.Name = "serv_descricaoLabel";
            serv_descricaoLabel.Size = new System.Drawing.Size(139, 30);
            serv_descricaoLabel.TabIndex = 2;
            serv_descricaoLabel.Text = "descrição:";
            // 
            // serv_precoLabel
            // 
            serv_precoLabel.AutoSize = true;
            serv_precoLabel.Location = new System.Drawing.Point(31, 215);
            serv_precoLabel.Name = "serv_precoLabel";
            serv_precoLabel.Size = new System.Drawing.Size(141, 30);
            serv_precoLabel.TabIndex = 4;
            serv_precoLabel.Text = "valor total:";
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Location = new System.Drawing.Point(31, 274);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(100, 30);
            serv_tempoLabel.TabIndex = 6;
            serv_tempoLabel.Text = "tempo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(serv_codigoLabel);
            this.groupBox1.Controls.Add(this.serv_codigoLabel1);
            this.groupBox1.Controls.Add(serv_descricaoLabel);
            this.groupBox1.Controls.Add(this.serv_descricaoTextBox);
            this.groupBox1.Controls.Add(serv_precoLabel);
            this.groupBox1.Controls.Add(this.serv_precoTextBox);
            this.groupBox1.Controls.Add(serv_tempoLabel);
            this.groupBox1.Controls.Add(this.serv_tempoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(279, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços ";
            // 
            // serv_codigoLabel1
            // 
            this.serv_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_codigo", true));
            this.serv_codigoLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serv_codigoLabel1.Location = new System.Drawing.Point(275, 104);
            this.serv_codigoLabel1.Name = "serv_codigoLabel1";
            this.serv_codigoLabel1.Size = new System.Drawing.Size(63, 25);
            this.serv_codigoLabel1.TabIndex = 1;
            this.serv_codigoLabel1.Text = "label1";
            this.serv_codigoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servicosBindingSource
            // 
            this.servicosBindingSource.DataMember = "servicos";
            this.servicosBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serv_descricaoTextBox
            // 
            this.serv_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_descricao", true));
            this.serv_descricaoTextBox.Location = new System.Drawing.Point(176, 149);
            this.serv_descricaoTextBox.Name = "serv_descricaoTextBox";
            this.serv_descricaoTextBox.Size = new System.Drawing.Size(383, 37);
            this.serv_descricaoTextBox.TabIndex = 3;
            // 
            // serv_precoTextBox
            // 
            this.serv_precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_preco", true));
            this.serv_precoTextBox.Location = new System.Drawing.Point(176, 208);
            this.serv_precoTextBox.Name = "serv_precoTextBox";
            this.serv_precoTextBox.Size = new System.Drawing.Size(118, 37);
            this.serv_precoTextBox.TabIndex = 5;
            // 
            // serv_tempoTextBox
            // 
            this.serv_tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicosBindingSource, "serv_tempo", true));
            this.serv_tempoTextBox.Location = new System.Drawing.Point(176, 267);
            this.serv_tempoTextBox.Name = "serv_tempoTextBox";
            this.serv_tempoTextBox.Size = new System.Drawing.Size(118, 37);
            this.serv_tempoTextBox.TabIndex = 7;
            // 
            // servicosTableAdapter
            // 
            this.servicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamentos_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentosTableAdapter = null;
            this.tableAdapterManager.animaisTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.racasTableAdapter = null;
            this.tableAdapterManager.servicosTableAdapter = this.servicosTableAdapter;
            this.tableAdapterManager.UpdateOrder = LednewPet.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicosBindingNavigator
            // 
            this.servicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicosBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.servicosBindingNavigator.BindingSource = this.servicosBindingSource;
            this.servicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.servicosBindingNavigator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicosBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.servicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicosBindingNavigatorSaveItem,
            this.BtnCancelar,
            this.BtnEditar});
            this.servicosBindingNavigator.Location = new System.Drawing.Point(437, 52);
            this.servicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicosBindingNavigator.Name = "servicosBindingNavigator";
            this.servicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicosBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.servicosBindingNavigator.Size = new System.Drawing.Size(564, 39);
            this.servicosBindingNavigator.TabIndex = 1;
            this.servicosBindingNavigator.Text = "bindingNavigator1";
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
            // servicosBindingNavigatorSaveItem
            // 
            this.servicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicosBindingNavigatorSaveItem.Image")));
            this.servicosBindingNavigatorSaveItem.Name = "servicosBindingNavigatorSaveItem";
            this.servicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.servicosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicosBindingNavigatorSaveItem_Click);
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
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(81, 36);
            this.BtnEditar.Text = "Editar";
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.servicosBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServicos";
            this.Text = "frmServicos";
            this.Load += new System.EventHandler(this.frmServicos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicosBindingNavigator)).EndInit();
            this.servicosBindingNavigator.ResumeLayout(false);
            this.servicosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource servicosBindingSource;
        private petshopDataSetTableAdapters.servicosTableAdapter servicosTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label serv_codigoLabel1;
        private System.Windows.Forms.TextBox serv_descricaoTextBox;
        private System.Windows.Forms.TextBox serv_precoTextBox;
        private System.Windows.Forms.TextBox serv_tempoTextBox;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripButton BtnEditar;
    }
}