using Alura.Loja.Testes.ConsoleApp;

namespace Alura.Loja.Testes.CosoleApp
{
    public class PromocaoProduto
    {
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int PromocaoId { get; set; }
        public Promocao Promocao { get; set; }
    }
}
