
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Model.Classes.Contextos;
using SistemaHotel.Model.Classes.Entidades;
using System.Drawing.Text;

namespace SistemaHotel.Produtos
{
    public partial class FrmProdutos : Form
    {
        private bool cadastrandoProduto = false;
        private Estoque produtoSelecionado;

        string id;

        public FrmProdutos()
        {
            InitializeComponent();
        }


        private void CarregarCombobox()
        {

        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {



            FormatarDG();
        }


        private void BuscarNome()
        {


            FormatarDG();
        }



        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            txtEstoque.Enabled = true;
            btnImg.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            txtEstoque.Enabled = false;
            btnImg.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            cbFornecedor.Text = "";
            LimparFoto();
        }
        private void LimparFoto()
        {
            img.Image = Properties.Resources.sem_foto;
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            LimparFoto();
            CarregarCombobox();
            Listar();
        }

        //Cadastro de produtos
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            ContextoEstoque estoque = new ContextoEstoque();
            string busca = txtBuscarNome.Text.Trim();

            if (string.IsNullOrEmpty(busca))
            {
                MessageBox.Show("Digite um produto para buscar.");
                return;
            }

            var produto = estoque.Estoques.FirstOrDefault(p => p.NomeProduto == busca);

            if (produto != null)
            {
                PreencherProduto(produto);
            }
            else
            {
                PerguntarNovoProduto();
            }

            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }
        private void PreencherProduto(Estoque produto)
        {
            cadastrandoProduto = false;
            produtoSelecionado = produto;

            txtNome.Text = produto.NomeProduto;
            txtDescricao.Text = produto.Descricao;
            txtValor.Text = produto.Valor.ToString("N2");
            cbFornecedor.Text = produto.Fornecedor;

            txtEstoque.Enabled = true;
        }

        private void PerguntarNovoProduto()
        {
            /*var resultado = MessageBox.Show("Produto não encontrado. Deseja cadastrar um novo produto?", "Produto não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                limparCampos();
                habilitarCampos();
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }*/
            DialogResult resultado = MessageBox.Show("Produto não encontrado. Deseja cadastrar um novo produto?", "Produto não encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                habilitarCampos();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            //CÓDIGO DO BOTÃO PARA SALVAR

            if (cadastrandoProduto)
            {
                CadastrarProduto();
            }
            else
            {
                AdicionarEstoque();
            }



            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void CadastrarProduto()
        {
            string nomeProduto = txtNome.Text;
            string descricaoProduto = txtDescricao.Text;

            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(descricaoProduto))
            {
                MessageBox.Show("Preencha a Descrição", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Focus();
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoqueProduto))
            {
                MessageBox.Show("Preencha o Estoque corretamente", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEstoque.Focus();
                return;
            }

            if (cbFornecedor.SelectedValue == null && string.IsNullOrWhiteSpace(cbFornecedor.Text))
            {
                MessageBox.Show("Selecione um fornecedor.");
                cbFornecedor.Focus();
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out decimal valorProdutoDecimal))
            {
                MessageBox.Show("Preencha o Valor corretamente", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }

            long valorProdutoLong = (long)valorProdutoDecimal;

            var novo = new Estoque(
                0,
                nomeProduto,
                descricaoProduto,
                estoqueProduto,
                cbFornecedor.Text,
                valorProdutoLong,
                0
            );

            using (var salvar = new ContextoEstoque())
            {
                salvar.Estoques.Add(novo);
                salvar.SaveChanges();
            }
        }

        private void AdicionarEstoque()
        {
            if (!int.TryParse(txtEstoque.Text, out int quantidade))
            {
                MessageBox.Show("Informe uma quantidade válida.");
                txtEstoque.Focus();
                return;
            }

            //Não pode ser negativo nem zero
            if (quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.");
                txtEstoque.Focus();
                return;
            }

            produtoSelecionado.Estoque += quantidade;

            // Salvar alteração
            var adicionar = new ContextoEstoque();
            adicionar.SaveChanges();
            MessageBox.Show("Estoque atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR


            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR


                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                limparCampos();
                desabilitarCampos();
                Listar();
            }
        }

        private void BtnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg;*.png)|*.jpg;*.png|Todos os Arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                img.ImageLocation = foto;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = grid.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtValor.Text = grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.chamadaProdutos == "estoque")
            {
                Program.nomeProduto = grid.CurrentRow.Cells[1].Value.ToString();
                Program.estoqueProduto = grid.CurrentRow.Cells[3].Value.ToString();
                Program.idProduto = grid.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
