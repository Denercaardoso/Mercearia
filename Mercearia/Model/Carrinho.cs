using System;
using System.Collections.Generic;

namespace Mercearia.Model
{
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataTransacao { get; private set; }
        public List<Transacao> Transacoes { get; set; }
    }
}
