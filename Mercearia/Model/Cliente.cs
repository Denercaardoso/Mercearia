using System;

namespace Mercearia.Model
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; private set; }
    }
}
