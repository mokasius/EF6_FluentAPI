using System.Collections.Generic;

namespace EF6_FluentAPI
{
    public  class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
