using System;

namespace Mercearia.Model
{
    class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
