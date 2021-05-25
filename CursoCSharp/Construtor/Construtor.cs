using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Construtor
{
    class Construtor
    {
        public static void MenuConstrutor()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Para sair digite 0 \n");
            Globais.op_ex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            switch (Globais.op_ex){ 
                case 0:
                    break;
                case 1:
                    Exercicio01();
                    break;
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuConstrutor();
                    break;
            }
        }
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            string nome;
            int deposito;
            int opcao=0;
            double valor;
            double valor_deposito = 0;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Deseja criar sua conta com um deposito inicial? (1 - Sim, 2 - Não): ");
            deposito = Convert.ToInt32(Console.ReadLine());
            switch (deposito)
            {
                case 1:
                    Console.WriteLine("\nDigite o valor inicial de deposito: ");
                    valor_deposito = Convert.ToDouble(Console.ReadLine());
                    
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Digite um valor valido.");
                    break;
            }
            if(deposito != 1 && deposito!= 2)
            {
                Limpar.LimparTela();
                Exercicio01();
            }
            else {
                Banco c1 = new Banco(nome, valor_deposito);
                while (opcao != 5)
                {
                    Limpar.LimparTela();
                    Console.WriteLine("\n\nBem vindo(a) {0} \nDeseja realizar Saque (1)\nDeposito (2)\nConsultar Saldo (3) \nTrocar nome (4)\nSair (5)", c1.Name);
                    opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\nDigite o valor do saque: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            c1.Saque = valor;
                            break;
                        case 2:
                            Console.WriteLine("\nDigite o valor do deposito: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            c1.Deposito = valor;
                            break;
                        case 3:
                            Console.WriteLine("\nNa conta de {0} o saldo é de: {1}", c1.Name, c1.Saldo);
                            break;
                        case 4:
                            Console.WriteLine("Digite seu novo nome: ");
                            nome = Console.ReadLine();
                            c1.Name = nome;
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("\nDigite um valor valido.");
                            opcao = 4;
                            break;
                    }
                }
            }
        }
            
    }
}
