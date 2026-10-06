namespace SistemaHotel.Cadastros
{
    partial class FrmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarios));
            label1 = new System.Windows.Forms.Label();
            txtBuscarNome = new System.Windows.Forms.TextBox();
            txtNome = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtCPF = new System.Windows.Forms.MaskedTextBox();
            txtEndereco = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtTelefone = new System.Windows.Forms.MaskedTextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            cbCargo = new System.Windows.Forms.ComboBox();
            grid = new System.Windows.Forms.DataGridView();
            txtBuscarCPF = new System.Windows.Forms.MaskedTextBox();
            rbNome = new System.Windows.Forms.RadioButton();
            rbCPF = new System.Windows.Forms.RadioButton();
            btnExcluir = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(358, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar:";
            // 
            // txtBuscarNome
            // 
            txtBuscarNome.Location = new System.Drawing.Point(609, 14);
            txtBuscarNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBuscarNome.Name = "txtBuscarNome";
            txtBuscarNome.Size = new System.Drawing.Size(134, 23);
            txtBuscarNome.TabIndex = 50;
            txtBuscarNome.TextChanged += TxtBuscarNome_TextChanged;
            txtBuscarNome.KeyDown += txtBuscarNome_KeyDown;
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new System.Drawing.Point(110, 78);
            txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(134, 23);
            txtNome.TabIndex = 1;
            txtNome.Click += txtNome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 82);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 51;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(287, 85);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 53;
            label3.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Enabled = false;
            txtCPF.Location = new System.Drawing.Point(342, 78);
            txtCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new System.Drawing.Size(130, 23);
            txtCPF.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Enabled = false;
            txtEndereco.Location = new System.Drawing.Point(609, 78);
            txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new System.Drawing.Size(134, 23);
            txtEndereco.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(526, 81);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 55;
            label4.Text = "Endereço:";
            // 
            // txtTelefone
            // 
            txtTelefone.Enabled = false;
            txtTelefone.Location = new System.Drawing.Point(110, 126);
            txtTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtTelefone.Mask = "(99) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new System.Drawing.Size(130, 23);
            txtTelefone.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(42, 134);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 57;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(287, 129);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 15);
            label6.TabIndex = 58;
            label6.Text = "Cargo:";
            // 
            // cbCargo
            // 
            cbCargo.Enabled = false;
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Admin", "Funcionario" });
            cbCargo.Location = new System.Drawing.Point(342, 123);
            cbCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new System.Drawing.Size(130, 23);
            cbCargo.TabIndex = 5;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.GridColor = System.Drawing.SystemColors.Control;
            grid.Location = new System.Drawing.Point(31, 175);
            grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new System.Drawing.Size(742, 215);
            grid.TabIndex = 60;
            grid.CellClick += Grid_CellClick;
            grid.Click += Grid_Click;
            // 
            // txtBuscarCPF
            // 
            txtBuscarCPF.Location = new System.Drawing.Point(609, 48);
            txtBuscarCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBuscarCPF.Mask = "000,000,000-00";
            txtBuscarCPF.Name = "txtBuscarCPF";
            txtBuscarCPF.Size = new System.Drawing.Size(134, 23);
            txtBuscarCPF.TabIndex = 61;
            txtBuscarCPF.Visible = false;
            txtBuscarCPF.TextChanged += TxtBuscarCPF_TextChanged;
            txtBuscarCPF.KeyDown += txtBuscarCPF_KeyDown;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Location = new System.Drawing.Point(420, 16);
            rbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNome.Name = "rbNome";
            rbNome.Size = new System.Drawing.Size(58, 19);
            rbNome.TabIndex = 62;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            rbNome.CheckedChanged += RbNome_CheckedChanged;
            // 
            // rbCPF
            // 
            rbCPF.AutoSize = true;
            rbCPF.Location = new System.Drawing.Point(498, 16);
            rbCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbCPF.Name = "rbCPF";
            rbCPF.Size = new System.Drawing.Size(46, 19);
            rbCPF.TabIndex = 63;
            rbCPF.TabStop = true;
            rbCPF.Text = "CPF";
            rbCPF.UseVisualStyleBackColor = true;
            rbCPF.CheckedChanged += RbCPF_CheckedChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcluir.Image = (System.Drawing.Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new System.Drawing.Point(498, 417);
            btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(82, 75);
            btnExcluir.TabIndex = 67;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Image = (System.Drawing.Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new System.Drawing.Point(404, 417);
            btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(82, 75);
            btnEditar.TabIndex = 66;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSalvar.Enabled = false;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSalvar.Image = (System.Drawing.Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new System.Drawing.Point(308, 417);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(82, 75);
            btnSalvar.TabIndex = 65;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNovo.Image = (System.Drawing.Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new System.Drawing.Point(214, 417);
            btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new System.Drawing.Size(82, 75);
            btnNovo.TabIndex = 64;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // FrmFuncionarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(799, 519);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(rbCPF);
            Controls.Add(rbNome);
            Controls.Add(txtBuscarCPF);
            Controls.Add(grid);
            Controls.Add(cbCargo);
            Controls.Add(label6);
            Controls.Add(txtTelefone);
            Controls.Add(label5);
            Controls.Add(txtEndereco);
            Controls.Add(label4);
            Controls.Add(txtCPF);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtBuscarNome);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmFuncionarios";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tela de Funcionarios";
            Load += FrmFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MaskedTextBox txtBuscarCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
    }
}