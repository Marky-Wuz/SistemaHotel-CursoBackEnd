
using Microsoft.IdentityModel.Tokens;
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

namespace SistemaHotel.Cadastros
{
    public partial class FrmFuncionarios : Form
    {


        string id;
        ContextoUsuario contexto = new ContextoUsuario();

        string cpfAntigo;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void CarregarCombobox()
        {

        }


        private void FormatarDG(string filtro = "")
        {
            {
                try
                {
                    var listadeprocura = contexto.usuarios.ToList();
                    {
                        switch (filtro)
                        {
                            case "nome":
                                listadeprocura = contexto.usuarios.Where(u => u.NomeDoUsuario.Contains(txtBuscarNome.Text)).ToList();
                                break;
                            case "cpf":
                                listadeprocura = contexto.usuarios.Where(u => u.Cpf.ToString().Contains(txtBuscarCPF.Text)).ToList();
                                break;
                            default:
                                grid.DataSource = contexto.usuarios.ToList();
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }

            }
        }
        private void Listar()
        {
            grid.DataSource = contexto.usuarios.ToList();


            FormatarDG();
        }


        private void BuscarNome()
        {
            if (rbNome.Checked)
            {
                ContextoUsuario contexto = new ContextoUsuario();
                FormatarDG("nome");
            }
            else
            {
                MessageBox.Show("Selecione o Tipo de Busca!");
            }

        }


        private void BuscarCPF()
        {
            if (rbCPF.Checked)
            {
                ContextoUsuario contexto = new ContextoUsuario();
                FormatarDG("cpf");
            }
            else
            {
                MessageBox.Show("Selecione o Tipo de Busca!");
            }

        }



        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }




        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            Listar();
            rbNome.Checked = true;
            CarregarCombobox();

            if (!txtNome.Text.IsNullOrEmpty() && !txtCPF.Text.IsNullOrEmpty() && !txtEndereco.Text.IsNullOrEmpty() && !txtTelefone.Text.IsNullOrEmpty())
            {
                btnSalvar.Enabled = true;

            }
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";

        }

        private void RbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

            if (btnNovo.Enabled)
            {
                habilitarCampos();
                btnSalvar.Enabled = true;
            }
            else
            {
                desabilitarCampos();
            }

            if (!txtNome.Text.IsNullOrEmpty() && !txtCPF.Text.IsNullOrEmpty() && !txtEndereco.Text.IsNullOrEmpty() && !txtTelefone.Text.IsNullOrEmpty())
            {
                var resultado = MessageBox.Show("Tem Certeza que quer adicionar um novo Usuário?", "Confirmação", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    limparCampos();
                    return;
                }
                else if (resultado == DialogResult.No)
                {
                    Close();
                }
                return;
            }
            btnSalvar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (txtNome.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text.ToString().Trim() == "")
            {
                txtCPF.Text = "";
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR
            var nome = txtNome.Text;
            var cpf = (txtCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", ""));
            var endereco = txtEndereco.Text;
            var telefone = (txtTelefone.Text.Replace(".", "").Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", ""));
            var cargo = cbCargo.Text;

            Usuario usuario = new Usuario(nome, long.Parse(cpf), long.Parse(telefone), endereco, cargo);

            contexto.usuarios.Add(usuario);



            //VERIFICAR SE O CPF JÁ EXISTE NO BANCO
            string cpfA = txtCPF.Text;


            if (cpfA.Equals(contexto.usuarios.Select(u => u.Cpf).FirstOrDefault().ToString()))
            {
                MessageBox.Show("CPF já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscarCPF.Text = "";
                txtBuscarCPF.Focus();
                return;
            }



            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limparCampos();
            desabilitarCampos();
            Listar();
            contexto.SaveChanges();
            contexto.Update(usuario);
        }

        private void Grid_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                if (txtBuscarNome.Text.ToString().Trim() == "")
                {
                    txtBuscarNome.Text = "";
                    MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                    return;
                }

            }
            if (rbCPF.Checked)
            {
                if (txtBuscarCPF.Text == "")
                {
                    txtBuscarCPF.Text = "";
                    MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCPF.Focus();
                    return;
                }
            }

            if (!txtBuscarNome.Text.IsNullOrEmpty())
            {
                Pesquisas(true, false, txtBuscarNome.Text, grid);
            }
            else if (!txtBuscarCPF.Text.IsNullOrEmpty())
            {
                string textoCPF = (txtBuscarCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", ""));
                //MessageBox.Show("CPF: " + textoCPF);
                Pesquisas(false, true, textoCPF, grid);
            }




        }

        public void Pesquisas(bool nome, bool cpf, string texto, DataGridView grid)
        {
            if (nome)
            {
                grid.DataSource = contexto.usuarios.Where(u => u.NomeDoUsuario.Contains(texto)).ToList();
            }
            else if (cpf)
            {
                //MessageBox.Show("CPF: " + texto);
                grid.DataSource = contexto.usuarios.Where(u => u.Cpf.ToString().Contains(texto)).ToList();
            }
            else
            {
                grid.DataSource = contexto.usuarios.ToList();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var usuarioSelecionado = grid.CurrentRow.DataBoundItem as Usuario;
            if (usuarioSelecionado != null)
            {
                var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    //CÓDIGO DO BOTÃO PARA EXCLUIR
                    contexto.usuarios.Remove(usuarioSelecionado);

                    //Excluir o registro selecionado no DataGridView



                    MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNovo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                    limparCampos();
                    desabilitarCampos();
                    Listar();
                }

            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells["NomeDoUsuario"].Value.ToString();
            txtCPF.Text = grid.CurrentRow.Cells["CPF"].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells["Telefone"].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells["Regra"].Value.ToString();

            cpfAntigo = grid.CurrentRow.Cells["CPF"].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void TxtBuscarCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCPF.Text == "   .   .   -")
            {
                Listar();
            }
            else
            {
                BuscarCPF();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarNome_KeyDown(object sender, KeyEventArgs e)
        {
            bool nomebutton = txtBuscarNome.Text.IsNullOrEmpty();
            if (nomebutton != default(bool))
            {
                if (txtBuscarNome.Text.IsNullOrEmpty() && txtBuscarCPF.Text.IsNullOrEmpty())
                {
                    FormatarDG();
                }
                else if (rbNome.Checked)
                {
                    BuscarNome();
                }

            }

            if (txtBuscarNome.Text.IsNullOrEmpty())
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }

        private void txtBuscarCPF_KeyDown(object sender, KeyEventArgs e)
        {
            bool cpfbutton = txtBuscarCPF.Text.IsNullOrEmpty();
            if (cpfbutton != default(bool))
            {

                if (txtBuscarCPF.Text.IsNullOrEmpty())
                {
                    FormatarDG();
                }
                else if (rbCPF.Checked)
                {
                    BuscarCPF();
                }
            }

            if (txtBuscarCPF.Text.IsNullOrEmpty())
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.FirstOrDefault() == ' ')
            {
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                txtNome.Text = txtNome.Text.Substring(1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
