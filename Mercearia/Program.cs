﻿using System;

namespace Mercearia
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();

            void MenuPrincipal()
            {

                bool RepeticoaoMenu = true;
                while (RepeticoaoMenu)
                {
                    Console.WriteLine("MENU MERCEARIA");
                    Console.WriteLine("1 - Cadastrar produto");
                    Console.WriteLine("2 - Vender Produto");
                    Console.WriteLine("3 - Comprar de Fornecedor");
                    Console.WriteLine("4 - Relatório de Estoque");
                    Console.WriteLine("5 - Sair");
                    Console.WriteLine("Selecione a opção desejada:");
                    string opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            //CadastrarProduto();
                            break;

                        case "2":
                            //VenderProduto();
                            break;

                        case "3":
                            //ComprarDeFornecedor();
                            break;

                        case "4":
                            //RelatorioDeEstoque();
                            break;

                        case "5":
                            Console.WriteLine("Sessão Encerrada!");
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Opção invalida!");
                            break;

                    }
                }

            }
        }

    }
}
