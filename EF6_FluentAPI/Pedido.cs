namespace EF6_FluentAPI
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Item { get; set; }
        public int Quantidade { get; set; }
        public int Preco { get; set; }
        public int? ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
