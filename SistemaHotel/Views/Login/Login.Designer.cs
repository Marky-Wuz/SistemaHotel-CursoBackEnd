namespace SistemaHotel
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlLogin = new System.Windows.Forms.Panel();
            btnLogin = new System.Windows.Forms.Button();
            txtSenha = new System.Windows.Forms.TextBox();
            txtUsuario = new System.Windows.Forms.TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = System.Drawing.Color.Transparent;
            pnlLogin.BackgroundImage = (System.Drawing.Image)resources.GetObject("pnlLogin.BackgroundImage");
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Location = new System.Drawing.Point(34, 50);
            pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new System.Drawing.Size(340, 464);
            pnlLogin.TabIndex = 0;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnLogin.Location = new System.Drawing.Point(46, 250);
            btnLogin.Margin = new System.Windows.Forms.Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(246, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSenha.Location = new System.Drawing.Point(67, 211);
            txtSenha.Margin = new System.Windows.Forms.Padding(4);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new System.Drawing.Size(242, 16);
            txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsuario.Location = new System.Drawing.Point(67, 156);
            txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(242, 16);
            txtUsuario.TabIndex = 1;
            // 
            // FrmLogin
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoSize = true;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(411, 541);
            Controls.Add(pnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            KeyDown += FrmLogin_KeyDown;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
    }
}

