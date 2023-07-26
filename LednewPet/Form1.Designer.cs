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
            this.PanelRight = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnRacas = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelSelect = new System.Windows.Forms.Panel();
            this.PanelCenter.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.Color.MintCream;
            this.PanelCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelCenter.BackgroundImage")));
            this.PanelCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCenter.Controls.Add(this.PanelRight);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelCenter.ForeColor = System.Drawing.Color.SeaGreen;
            this.PanelCenter.Location = new System.Drawing.Point(0, 52);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1030, 612);
            this.PanelCenter.TabIndex = 1;
            this.PanelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCenter_Paint);
            // 
            // PanelRight
            // 
            this.PanelRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelRight.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelRight.Location = new System.Drawing.Point(756, 36);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(261, 535);
            this.PanelRight.TabIndex = 9;
            this.PanelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRight_Paint);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelLeft.Controls.Add(this.PanelSelect);
            this.PanelLeft.Controls.Add(this.btnHome);
            this.PanelLeft.Controls.Add(this.btnAgendamentos);
            this.PanelLeft.Controls.Add(this.btnServicos);
            this.PanelLeft.Controls.Add(this.btnRacas);
            this.PanelLeft.Controls.Add(this.btnAnimais);
            this.PanelLeft.Controls.Add(this.btnClientes);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.ForeColor = System.Drawing.Color.White;
            this.PanelLeft.Location = new System.Drawing.Point(0, 52);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(277, 612);
            this.PanelLeft.TabIndex = 1;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint_1);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(33, 35);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(237, 53);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgendamentos.Location = new System.Drawing.Point(33, 517);
            this.btnAgendamentos.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Padding = new System.Windows.Forms.Padding(2);
            this.btnAgendamentos.Size = new System.Drawing.Size(237, 53);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServicos.Location = new System.Drawing.Point(33, 423);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(5);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(2);
            this.btnServicos.Size = new System.Drawing.Size(237, 53);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnRacas
            // 
            this.btnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRacas.Location = new System.Drawing.Point(33, 227);
            this.btnRacas.Margin = new System.Windows.Forms.Padding(5);
            this.btnRacas.Name = "btnRacas";
            this.btnRacas.Padding = new System.Windows.Forms.Padding(2);
            this.btnRacas.Size = new System.Drawing.Size(237, 53);
            this.btnRacas.TabIndex = 2;
            this.btnRacas.Text = "Raças";
            this.btnRacas.UseVisualStyleBackColor = true;
            this.btnRacas.Click += new System.EventHandler(this.btnRacas_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnimais.Location = new System.Drawing.Point(33, 323);
            this.btnAnimais.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Padding = new System.Windows.Forms.Padding(2);
            this.btnAnimais.Size = new System.Drawing.Size(237, 53);
            this.btnAnimais.TabIndex = 1;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(33, 138);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(2);
            this.btnClientes.Size = new System.Drawing.Size(237, 53);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(206, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 531);
            this.panel3.TabIndex = 0;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTop.Controls.Add(this.btnMin);
            this.PanelTop.Controls.Add(this.btnSair);
            this.PanelTop.Controls.Add(this.panel3);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.ForeColor = System.Drawing.Color.White;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1030, 52);
            this.PanelTop.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(950, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 35);
            this.btnMin.TabIndex = 8;
            this.btnMin.Text = "-";
            this.btnMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(991, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(35, 35);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "X";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 664);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCenter.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelCenter;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnRacas;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelSelect;
    }
}

