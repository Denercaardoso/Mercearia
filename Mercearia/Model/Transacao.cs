using Mercearia.Model.Enums;

namespace Mercearia.Model
{
    class Transacao
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorProduto { get; set; }
        public TipoTransacao TipoTransacao { get; set; }

        public static Transacao Compra(Produto produto, Fornecedor fornecedor, int quantidade, decimal valorProduto)
        {
            return new Transacao()
            {
                Produto = produto,
                Fornecedor = fornecedor,
                Quantidade = quantidade,
                ValorProduto = valorProduto,
                TipoTransacao = TipoTransacao.COMPRA
            };
        }

        public static Transacao Venda(Produto produto, Cliente cliente, int quantidade, decimal valorProduto)
        {
            return new Transacao()
            {
                Produto = produto,
                Cliente = cliente,
                Quantidade = quantidade,
                ValorProduto = valorProduto,
                TipoTransacao = TipoTransacao.VENDA
            };
        }
    }

}

