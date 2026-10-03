
namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Estoque : Produtos
    {

        //Propriedades
        public int Quantidade { get; set; }

        //Construtores
        public Estoque(int Id,string nomeProduto, string descricao, int estoque, string fornecedor, long valor, int quantidade) : base(Id, nomeProduto, descricao, estoque, fornecedor, valor)
        {
            Quantidade = quantidade;
        }
    }
}
