namespace SistemaHotel.Produtos
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            grid = new System.Windows.Forms.DataGridView();
            cbFornecedor = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtValor = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNome = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtBuscarNome = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtDescricao = new System.Windows.Forms.TextBox();
            txtEstoque = new System.Windows.Forms.TextBox();
            btnImg = new System.Windows.Forms.Button();
            img = new System.Windows.Forms.PictureBox();
            btnExcluir = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnNovo = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // grid
            // 
            grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.GridColor = System.Drawing.SystemColors.Control;
            grid.Location = new System.Drawing.Point(29, 186);
            grid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            grid.Name = "grid";
            grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new System.Drawing.Size(790, 215);
            grid.TabIndex = 80;
            grid.CellClick += Grid_CellClick;
            grid.CellContentClick += grid_CellContentClick;
            grid.CellDoubleClick += Grid_CellDoubleClick;
            // 
            // cbFornecedor
            // 
            cbFornecedor.Enabled = false;
            cbFornecedor.FormattingEnabled = true;
            cbFornecedor.Location = new System.Drawing.Point(337, 129);
            cbFornecedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbFornecedor.Name = "cbFornecedor";
            cbFornecedor.Size = new System.Drawing.Size(118, 23);
            cbFornecedor.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(255, 133);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 15);
            label6.TabIndex = 79;
            label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(26, 134);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 15);
            label5.TabIndex = 78;
            label5.Text = "Estoque:";
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Location = new System.Drawing.Point(522, 129);
            txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtValor.Name = "txtValor";
            txtValor.Size = new System.Drawing.Size(78, 23);
            txtValor.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(475, 133);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 15);
            label4.TabIndex = 77;
            label4.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(255, 89);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 15);
            label3.TabIndex = 76;
            label3.Text = "Descrição:";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new System.Drawing.Point(90, 85);
            txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(134, 23);
            txtNome.TabIndex = 69;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(26, 90);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 75;
            label2.Text = "Nome:";
            // 
            // txtBuscarNome
            // 
            txtBuscarNome.Location = new System.Drawing.Point(465, 14);
            txtBuscarNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtBuscarNome.Name = "txtBuscarNome";
            txtBuscarNome.Size = new System.Drawing.Size(134, 23);
            txtBuscarNome.TabIndex = 74;
            txtBuscarNome.TextChanged += TxtBuscarNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(408, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 68;
            label1.Text = "Buscar:";
            // 
            // txtDescricao
            // 
            txtDescricao.Enabled = false;
            txtDescricao.Location = new System.Drawing.Point(337, 85);
            txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new System.Drawing.Size(262, 23);
            txtDescricao.TabIndex = 88;
            // 
            // txtEstoque
            // 
            txtEstoque.Enabled = false;
            txtEstoque.Location = new System.Drawing.Point(90, 129);
            txtEstoque.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new System.Drawing.Size(134, 23);
            txtEstoque.TabIndex = 89;
            // 
            // btnImg
            // 
            btnImg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            btnImg.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImg.Enabled = false;
            btnImg.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnImg.Location = new System.Drawing.Point(792, 128);
            btnImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImg.Name = "btnImg";
            btnImg.Size = new System.Drawing.Size(27, 27);
            btnImg.TabIndex = 91;
            btnImg.Text = "+";
            btnImg.UseVisualStyleBackColor = false;
            btnImg.Click += BtnImg_Click;
            // 
            // img
            // 
            img.Location = new System.Drawing.Point(644, 17);
            img.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            img.Name = "img";
            img.Size = new System.Drawing.Size(140, 138);
            img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            img.TabIndex = 90;
            img.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExcluir.Enabled = false;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExcluir.Image = (System.Drawing.Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new System.Drawing.Point(533, 419);
            btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(82, 75);
            btnExcluir.TabIndex = 87;
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
            btnEditar.Location = new System.Drawing.Point(439, 419);
            btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(82, 75);
            btnEditar.TabIndex = 86;
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
            btnSalvar.Location = new System.Drawing.Point(343, 419);
            btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(82, 75);
            btnSalvar.TabIndex = 85;
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
            btnNovo.Location = new System.Drawing.Point(248, 419);
            btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new System.Drawing.Size(82, 75);
            btnNovo.TabIndex = 84;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += BtnNovo_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(90, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(134, 23);
            comboBox1.TabIndex = 92;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(849, 519);
            Controls.Add(comboBox1);
            Controls.Add(btnImg);
            Controls.Add(img);
            Controls.Add(txtEstoque);
            Controls.Add(txtDescricao);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grid);
            Controls.Add(cbFornecedor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtBuscarNome);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmProdutos";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tela de Produtos";
            Load += FrmProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}