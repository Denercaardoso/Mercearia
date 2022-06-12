using Mercearia.Model;
using System;

namespace Mercearia.View
{
    public class ProdutosView
    {

        public void CadastrarProtuto()
        {
            Produto produto = new();

            Console.WriteLine("Infome a descrição do Produto: ");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Informe a quantidade em estoque: ");
            produto.Estoque = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

        }

    }
}
