using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SistemaHotel.Cadastros;
using SistemaHotel.Model.Classes.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    static class Program
    {
        //DECLARAR AS VARIAVEIS GLOBAIS DO SISTEMA
        public static string nomeUsuario;
        public static string cargoUsuario;

        public static string chamadaProdutos;

        public static string nomeProduto;
        public static string estoqueProduto;
        public static string idProduto;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ContextoUsuario contextousu = new ContextoUsuario();
            contextousu.Database.EnsureCreated();

            if (TestarConexao())
            {
                MessageBox.Show("Conexão bem sucedida!");
                Application.Run(new FrmFuncionarios());
            }
            else
            {
                MessageBox.Show("Falha ao conectar ao banco de dados");
            }
            //Application.Run(new FrmFuncionarios());
        }

        private static bool TestarConexao()
        {
            try
            {
                using (var context = new ContextoUsuario())
                {
                    return context.Database.CanConnect();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

    }

}
