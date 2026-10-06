
namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Estoque : Produto
    {

        //Propriedades
        public int Quantidade { get; set; }

        //Construtores
        public Estoque(string nomeProduto, string descricao, int estoque, string fornecedor, decimal valor) : base(nomeProduto, descricao, estoque, fornecedor, valor)
        {
            Quantidade = 0;
        }
    }
}
