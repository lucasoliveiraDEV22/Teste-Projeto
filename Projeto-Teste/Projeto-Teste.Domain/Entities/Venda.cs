namespace ProjetoTeste.Domain.Entities
{
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public float ValorUnitario { get; set; }
        public DateTime DataVenda { get; set; }

        public float ValorTotal { get; set; }

        public Venda(int id, int clienteId, int produtoId, int quantidade, float valorUnitario, DateTime dataVenda)
        {
            Id = Guid.NewGuid();
            ClienteId = clienteId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            DataVenda = dataVenda;
            ValorTotal = Quantidade * ValorUnitario;
        }
        
    }
}