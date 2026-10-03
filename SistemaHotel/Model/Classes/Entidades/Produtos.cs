namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Produtos
    {
        //Propriedades
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public string Fornecedor { get; set; }
        public long Valor { get; set; }

        //Construtores
        public Produtos(int id, string nomeProduto, string descricao, int estoque, string fornecedor, long valor)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Estoque = estoque;
            Fornecedor = fornecedor;
            Valor = valor;
        }
    }
}
