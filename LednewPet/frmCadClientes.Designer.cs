namespace LednewPet
{
    partial class frmCadClientes
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
            System.Windows.Forms.Label cli_codigoLabel;
            System.Windows.Forms.Label cli_nomeLabel;
            System.Windows.Forms.Label cli_celularLabel;
            System.Windows.Forms.Label cli_emailLabel;
            System.Windows.Forms.Label cli_cpfLabel;
            System.Windows.Forms.Label cli_enderecoLabel;
            System.Windows.Forms.Label cli_fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cli_codigoLabel1 = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petshopDataSet = new LednewPet.petshopDataSet();
            this.cli_nomeTextBox = new System.Windows.Forms.TextBox();
            this.cli_celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_emailTextBox = new System.Windows.Forms.TextBox();
            this.cli_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cli_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cli_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.clientesTableAdapter = new LednewPet.petshopDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new LednewPet.petshopDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            cli_codigoLabel = new System.Windows.Forms.Label();
            cli_nomeLabel = new System.Windows.Forms.Label();
            cli_celularLabel = new System.Windows.Forms.Label();
            cli_emailLabel = new System.Windows.Forms.Label();
            cli_cpfLabel = new System.Windows.Forms.Label();
            cli_enderecoLabel = new System.Windows.Forms.Label();
            cli_fotoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cli_codigoLabel
            // 
            cli_codigoLabel.AutoSize = true;
            cli_codigoLabel.Location = new System.Drawing.Point(188, 68);
            cli_codigoLabel.Name = "cli_codigoLabel";
            cli_codigoLabel.Size = new System.Drawing.Size(141, 30);
            cli_codigoLabel.TabIndex = 0;
            cli_codigoLabel.Text = "cli codigo:";
            // 
            // cli_nomeLabel
            // 
            cli_nomeLabel.AutoSize = true;
            cli_nomeLabel.Location = new System.Drawing.Point(188, 98);
            cli_nomeLabel.Name = "cli_nomeLabel";
            cli_nomeLabel.Size = new System.Drawing.Size(126, 30);
            cli_nomeLabel.TabIndex = 2;
            cli_nomeLabel.Text = "cli nome:";
            // 
            // cli_celularLabel
            // 
            cli_celularLabel.AutoSize = true;
            cli_celularLabel.Location = new System.Drawing.Point(188, 137);
            cli_celularLabel.Name = "cli_celularLabel";
            cli_celularLabel.Size = new System.Drawing.Size(137, 30);
            cli_celularLabel.TabIndex = 4;
            cli_celularLabel.Text = "cli celular:";
            // 
            // cli_emailLabel
            // 
            cli_emailLabel.AutoSize = true;
            cli_emailLabel.Location = new System.Drawing.Point(188, 176);
            cli_emailLabel.Name = "cli_emailLabel";
            cli_emailLabel.Size = new System.Drawing.Size(123, 30);
            cli_emailLabel.TabIndex = 6;
            cli_emailLabel.Text = "cli email:";
            // 
            // cli_cpfLabel
            // 
            cli_cpfLabel.AutoSize = true;
            cli_cpfLabel.Location = new System.Drawing.Point(188, 215);
            cli_cpfLabel.Name = "cli_cpfLabel";
            cli_cpfLabel.Size = new System.Drawing.Size(95, 30);
            cli_cpfLabel.TabIndex = 8;
            cli_cpfLabel.Text = "cli cpf:";
            // 
            // cli_enderecoLabel
            // 
            cli_enderecoLabel.AutoSize = true;
            cli_enderecoLabel.Location = new System.Drawing.Point(188, 254);
            cli_enderecoLabel.Name = "cli_enderecoLabel";
            cli_enderecoLabel.Size = new System.Drawing.Size(173, 30);
            cli_enderecoLabel.TabIndex = 10;
            cli_enderecoLabel.Text = "cli endereco:";
            // 
            // cli_fotoLabel
            // 
            cli_fotoLabel.AutoSize = true;
            cli_fotoLabel.Location = new System.Drawing.Point(188, 290);
            cli_fotoLabel.Name = "cli_fotoLabel";
            cli_fotoLabel.Size = new System.Drawing.Size(103, 30);
            cli_fotoLabel.TabIndex = 12;
            cli_fotoLabel.Text = "cli foto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(cli_codigoLabel);
            this.groupBox1.Controls.Add(this.cli_codigoLabel1);
            this.groupBox1.Controls.Add(cli_nomeLabel);
            this.groupBox1.Controls.Add(this.cli_nomeTextBox);
            this.groupBox1.Controls.Add(cli_celularLabel);
            this.groupBox1.Controls.Add(this.cli_celularMaskedTextBox);
            this.groupBox1.Controls.Add(cli_emailLabel);
            this.groupBox1.Controls.Add(this.cli_emailTextBox);
            this.groupBox1.Controls.Add(cli_cpfLabel);
            this.groupBox1.Controls.Add(this.cli_cpfMaskedTextBox);
            this.groupBox1.Controls.Add(cli_enderecoLabel);
            this.groupBox1.Controls.Add(this.cli_enderecoTextBox);
            this.groupBox1.Controls.Add(cli_fotoLabel);
            this.groupBox1.Controls.Add(this.cli_fotoPictureBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // cli_codigoLabel1
            // 
            this.cli_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cli_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_codigo", true));
            this.cli_codigoLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_codigoLabel1.Location = new System.Drawing.Point(370, 69);
            this.cli_codigoLabel1.Name = "cli_codigoLabel1";
            this.cli_codigoLabel1.Size = new System.Drawing.Size(80, 23);
            this.cli_codigoLabel1.TabIndex = 1;
            this.cli_codigoLabel1.Text = "label1";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.petshopDataSet;
            // 
            // petshopDataSet
            // 
            this.petshopDataSet.DataSetName = "petshopDataSet";
            this.petshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cli_nomeTextBox
            // 
            this.cli_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_nome", true));
            this.cli_nomeTextBox.Location = new System.Drawing.Point(370, 95);
            this.cli_nomeTextBox.Name = "cli_nomeTextBox";
            this.cli_nomeTextBox.Size = new System.Drawing.Size(563, 37);
            this.cli_nomeTextBox.TabIndex = 3;
            // 
            // cli_celularMaskedTextBox
            // 
            this.cli_celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_celular", true));
            this.cli_celularMaskedTextBox.Location = new System.Drawing.Point(370, 134);
            this.cli_celularMaskedTextBox.Mask = "(99) 99999-9999";
            this.cli_celularMaskedTextBox.Name = "cli_celularMaskedTextBox";
            this.cli_celularMaskedTextBox.Size = new System.Drawing.Size(184, 37);
            this.cli_celularMaskedTextBox.TabIndex = 5;
            // 
            // cli_emailTextBox
            // 
            this.cli_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_email", true));
            this.cli_emailTextBox.Location = new System.Drawing.Point(370, 173);
            this.cli_emailTextBox.Name = "cli_emailTextBox";
            this.cli_emailTextBox.Size = new System.Drawing.Size(563, 37);
            this.cli_emailTextBox.TabIndex = 7;
            // 
            // cli_cpfMaskedTextBox
            // 
            this.cli_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_cpf", true));
            this.cli_cpfMaskedTextBox.Location = new System.Drawing.Point(370, 212);
            this.cli_cpfMaskedTextBox.Mask = "999,999,999-99";
            this.cli_cpfMaskedTextBox.Name = "cli_cpfMaskedTextBox";
            this.cli_cpfMaskedTextBox.Size = new System.Drawing.Size(184, 37);
            this.cli_cpfMaskedTextBox.TabIndex = 9;
            // 
            // cli_enderecoTextBox
            // 
            this.cli_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cli_endereco", true));
            this.cli_enderecoTextBox.Location = new System.Drawing.Point(370, 251);
            this.cli_enderecoTextBox.Name = "cli_enderecoTextBox";
            this.cli_enderecoTextBox.Size = new System.Drawing.Size(563, 37);
            this.cli_enderecoTextBox.TabIndex = 11;
            // 
            // cli_fotoPictureBox
            // 
            this.cli_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "cli_foto", true));
            this.cli_fotoPictureBox.Location = new System.Drawing.Point(370, 290);
            this.cli_fotoPictureBox.Name = "cli_fotoPictureBox";
            this.cli_fotoPictureBox.Size = new System.Drawing.Size(168, 228);
            this.cli_fotoPictureBox.TabIndex = 13;
            this.cli_fotoPictureBox.TabStop = false;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamentos_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentosTableAdapter = null;
            this.tableAdapterManager.animaisTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.racasTableAdapter = null;
            this.tableAdapterManager.servicosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LednewPet.petshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = null;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = null;
            this.clientesBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientesBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(1030, 39);
            this.clientesBindingNavigator.TabIndex = 1;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
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
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.clientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 36);
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(73, 36);
            this.btnEditar.Text = "Editar";
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCadClientes";
            this.Load += new System.EventHandler(this.frmCadClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private petshopDataSet petshopDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private petshopDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private petshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label cli_codigoLabel1;
        private System.Windows.Forms.TextBox cli_nomeTextBox;
        private System.Windows.Forms.MaskedTextBox cli_celularMaskedTextBox;
        private System.Windows.Forms.TextBox cli_emailTextBox;
        private System.Windows.Forms.MaskedTextBox cli_cpfMaskedTextBox;
        private System.Windows.Forms.TextBox cli_enderecoTextBox;
        private System.Windows.Forms.PictureBox cli_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}