namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Produto
    {
        //Propriedades
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }

        //Construtores
        public Produto(string nomeProduto, string descricao, int estoque, string fornecedor, decimal valor)
        {
            
            NomeProduto = nomeProduto;
            Descricao = descricao;
            Estoque = estoque;
            Fornecedor = fornecedor;
            Valor = valor;
        }
    }
}
