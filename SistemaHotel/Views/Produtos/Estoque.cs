
using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Contextos;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Produtos
{
    public partial class FrmEstoque : Form
    {
        string id;

        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void CarregarCombobox()
        {

        }

        private void habilitarCampos()
        {
            //txtProduto.Enabled = true;
            txtValor.Enabled = true;
            //txtEstoque.Enabled = true;
            cbFornecedor.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade.Focus();
            btnSalvar.Enabled = true;

        }


        private void desabilitarCampos()
        {
            txtProduto.Enabled = false;
            txtValor.Enabled = false;
            txtEstoque.Enabled = false;
            cbFornecedor.Enabled = false;
            txtQuantidade.Enabled = false;
            btnSalvar.Enabled = false;
        }


        private void limparCampos()
        {
            txtProduto.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
        }



        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            desabilitarCampos();
            //CarregarCombobox();
            CarregarProdutos();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();

            Program.chamadaProdutos = "estoque";
            Produtos.FrmProdutos form = new Produtos.FrmProdutos();
            form.Show();
        }

        private void FrmEstoque_Activated(object sender, EventArgs e)
        {
            txtEstoque.Text = Program.estoqueProduto;
            txtProduto.Text = Program.nomeProduto;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.ToString().Trim() == "")
            {
                txtProduto.Text = "";
                MessageBox.Show("Selecione um Produto", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Focus();
                return;
            }

            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha a Quantidade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR OS PRODUTOS


            MessageBox.Show("Lançamento Feito com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();
            desabilitarCampos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Estoque produto)
            {
                txtEstoque.Text = produto.Estoque.ToString();
                txtValor.Text = produto.Valor.ToString();
                cbFornecedor.Text = produto.Fornecedor.ToString();

                txtQuantidade.Enabled = true;
            }
            else
            {
                comboBox1.SelectedIndex = -1;
            }
        }
        private void CarregarProdutos()
        {
            ContextoEstoque produtos = new ContextoEstoque();

            var lista = produtos.Estoques.OrderBy(p => p.NomeProduto).ToList();

            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "NomeProduto";
            comboBox1.ValueMember = "Id";
        }
    }
}
