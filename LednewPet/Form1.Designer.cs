namespace LednewPet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.LabelLogoLeft = new System.Windows.Forms.Label();
            this.LabelLogoRight = new System.Windows.Forms.Label();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnAgendamentos = new System.Windows.Forms.Button();
            this.BtnServicos = new System.Windows.Forms.Button();
            this.BtnRacas = new System.Windows.Forms.Button();
            this.BtnAnimais = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PanelCenter.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.White;
            this.PanelCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCenter.BackgroundImage")));
            this.PanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelCenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelCenter.Controls.Add(this.LabelLogoLeft);
            this.PanelCenter.Controls.Add(this.LabelLogoRight);
            this.PanelCenter.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCenter.ForeColor = System.Drawing.Color.White;
            this.PanelCenter.Location = new System.Drawing.Point(277, 52);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(753, 613);
            this.PanelCenter.TabIndex = 1;
            this.PanelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCenter_Paint);
            // 
            // LabelLogoLeft
            // 
            this.LabelLogoLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLogoLeft.AutoSize = true;
            this.LabelLogoLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.LabelLogoLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelLogoLeft.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogoLeft.ForeColor = System.Drawing.Color.White;
            this.LabelLogoLeft.Location = new System.Drawing.Point(4, 138);
            this.LabelLogoLeft.Name = "LabelLogoLeft";
            this.LabelLogoLeft.Size = new System.Drawing.Size(140, 338);
            this.LabelLogoLeft.TabIndex = 11;
            this.LabelLogoLeft.Text = "* * * * *\r\n*U      *\r\n* N     *\r\n*   I     *\r\n*    P   *\r\n*     E  *\r\n*      T *\r" +
    "\n* * * * *";
            // 
            // LabelLogoRight
            // 
            this.LabelLogoRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLogoRight.AutoSize = true;
            this.LabelLogoRight.BackColor = System.Drawing.Color.SeaGreen;
            this.LabelLogoRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelLogoRight.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogoRight.ForeColor = System.Drawing.Color.White;
            this.LabelLogoRight.Location = new System.Drawing.Point(609, 138);
            this.LabelLogoRight.Name = "LabelLogoRight";
            this.LabelLogoRight.Size = new System.Drawing.Size(140, 338);
            this.LabelLogoRight.TabIndex = 10;
            this.LabelLogoRight.Text = "* * * * *\r\n*U      *\r\n* N     *\r\n*   I     *\r\n*    P   *\r\n*     E  *\r\n*      T *\r" +
    "\n* * * * *";
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelLeft.Controls.Add(this.PanelSelect);
            this.PanelLeft.Controls.Add(this.BtnHome);
            this.PanelLeft.Controls.Add(this.BtnAgendamentos);
            this.PanelLeft.Controls.Add(this.BtnServicos);
            this.PanelLeft.Controls.Add(this.BtnRacas);
            this.PanelLeft.Controls.Add(this.BtnAnimais);
            this.PanelLeft.Controls.Add(this.BtnClientes);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.ForeColor = System.Drawing.Color.White;
            this.PanelLeft.Location = new System.Drawing.Point(0, 52);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(277, 613);
            this.PanelLeft.TabIndex = 1;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint);
            // 
            // PanelSelect
            // 
            this.PanelSelect.BackColor = System.Drawing.Color.Honeydew;
            this.PanelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSelect.ForeColor = System.Drawing.Color.SeaGreen;
            this.PanelSelect.Location = new System.Drawing.Point(3, 35);
            this.PanelSelect.Name = "PanelSelect";
            this.PanelSelect.Size = new System.Drawing.Size(24, 53);
            this.PanelSelect.TabIndex = 10;
            // 
            // BtnHome
            // 
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnHome.Location = new System.Drawing.Point(33, 35);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(237, 53);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnAgendamentos
            // 
            this.BtnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendamentos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgendamentos.Location = new System.Drawing.Point(33, 517);
            this.BtnAgendamentos.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgendamentos.Name = "BtnAgendamentos";
            this.BtnAgendamentos.Padding = new System.Windows.Forms.Padding(2);
            this.BtnAgendamentos.Size = new System.Drawing.Size(237, 53);
            this.BtnAgendamentos.TabIndex = 4;
            this.BtnAgendamentos.Text = "Agendamentos";
            this.BtnAgendamentos.UseVisualStyleBackColor = true;
            this.BtnAgendamentos.Click += new System.EventHandler(this.BtnAgendamentos_Click);
            // 
            // BtnServicos
            // 
            this.BtnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnServicos.Location = new System.Drawing.Point(33, 423);
            this.BtnServicos.Margin = new System.Windows.Forms.Padding(5);
            this.BtnServicos.Name = "BtnServicos";
            this.BtnServicos.Padding = new System.Windows.Forms.Padding(2);
            this.BtnServicos.Size = new System.Drawing.Size(237, 53);
            this.BtnServicos.TabIndex = 3;
            this.BtnServicos.Text = "Serviços";
            this.BtnServicos.UseVisualStyleBackColor = true;
            this.BtnServicos.Click += new System.EventHandler(this.BtnServicos_Click);
            // 
            // BtnRacas
            // 
            this.BtnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRacas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRacas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRacas.Location = new System.Drawing.Point(33, 227);
            this.BtnRacas.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRacas.Name = "BtnRacas";
            this.BtnRacas.Padding = new System.Windows.Forms.Padding(2);
            this.BtnRacas.Size = new System.Drawing.Size(237, 53);
            this.BtnRacas.TabIndex = 2;
            this.BtnRacas.Text = "Raças";
            this.BtnRacas.UseVisualStyleBackColor = true;
            this.BtnRacas.Click += new System.EventHandler(this.BtnRacas_Click);
            // 
            // BtnAnimais
            // 
            this.BtnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimais.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnimais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAnimais.Location = new System.Drawing.Point(33, 323);
            this.BtnAnimais.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAnimais.Name = "BtnAnimais";
            this.BtnAnimais.Padding = new System.Windows.Forms.Padding(2);
            this.BtnAnimais.Size = new System.Drawing.Size(237, 53);
            this.BtnAnimais.TabIndex = 1;
            this.BtnAnimais.Text = "Animais";
            this.BtnAnimais.UseVisualStyleBackColor = true;
            this.BtnAnimais.Click += new System.EventHandler(this.BtnAnimais_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClientes.Location = new System.Drawing.Point(33, 138);
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(5);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(2);
            this.BtnClientes.Size = new System.Drawing.Size(237, 53);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTop.Controls.Add(this.LabelTitle);
            this.PanelTop.Controls.Add(this.BtnMin);
            this.PanelTop.Controls.Add(this.BtnSair);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.ForeColor = System.Drawing.Color.White;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1030, 52);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTop_Paint);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(303, 7);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(430, 30);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "\" * UNIPET, seu pet, nossa família! * \"";
            // 
            // BtnMin
            // 
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMin.Location = new System.Drawing.Point(938, 7);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(35, 35);
            this.BtnMin.TabIndex = 8;
            this.BtnMin.Text = "-";
            this.BtnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSair.Location = new System.Drawing.Point(981, 7);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(35, 35);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "X";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCenter.ResumeLayout(false);
            this.PanelCenter.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnAgendamentos;
        private System.Windows.Forms.Button BtnServicos;
        private System.Windows.Forms.Button BtnRacas;
        private System.Windows.Forms.Button BtnAnimais;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Panel PanelSelect;
        private System.Windows.Forms.Label LabelLogoRight;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelLogoLeft;
    }
}

