using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class Introducao
    {
        public static void MenuIntroducao()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Para sair digite 0 \n");
            Globais.op_ex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            switch (Globais.op_ex)
            {

                case 0:
                    break;
                case 1:
                    Exercicio01();
                    break;
                case 2:
                    Exercicio02();
                    break;
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuIntroducao();
                    break;
            }
        }

        /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
      velha.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = Convert.ToInt32(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else if (p2.idade > p1.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
            else
            {
                Console.WriteLine("Possuem a mesma idade.");
            }
        }

        /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
       médio dos funcionários.*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            double media;
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Digite os dados do primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionario: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = Convert.ToDouble(Console.ReadLine());

            media = (f1.salario + f2.salario) / 2;
            Console.WriteLine("A media salarial é de: " + media);

        }
    }
}
