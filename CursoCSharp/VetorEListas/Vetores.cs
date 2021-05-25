using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.VetorEListas
{
    class Vetores
    {
        public static void MenuVetores()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Exercicio 03 \n Para sair digite 0\n");
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
                case 3:
                    Exercicio03();
                    break;
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuVetores();
                    break;
            }
        }
        /*Fazer um programa para ler um número inteiro N e a altura de N pessoas.
        Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
        pessoas*/
        public static void Exercicio01()
        {
            int n, i;
            double altura;
            double[] alturas;
            double media, soma = 0;
            Console.WriteLine("Digite o numero de pessoas que serão avaliadas: ");
            n = Convert.ToInt32(Console.ReadLine());
            alturas = new double[n];
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                alturas[i] = altura;
                soma += altura;
            }
            media = soma / n;
            Console.WriteLine("Média de altura: " + Math.Round(media, 2));
        }
        /*Fazer um programa para ler um número inteiro N e os dados (nome e
        preço) de N Produtos. Armazene os N produtos em um vetor. Em
        seguida, mostrar o preço médio dos produtos.*/
        public static void Exercicio02()
        {
            int n=0, i;
            int produtos;
            double[] preco;
            string[] nome;
            int posicao = 0;
            double soma = 0, media;
            

            Console.WriteLine("Digite o numero de produtos que serão cadastrados: ");
            n = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[n, 2];

            produtos = n;
            
            preco = new double[n];
            nome = new string[n];

            for(i=0; i<n; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
                soma += preco[i];
                array[posicao, 0] = nome[i];
                posicao = 1;
                array[posicao, 1] = Convert.ToString(preco[i]);
                posicao = 0;
            }
            media = soma / n;
            Console.WriteLine("A média de preço é: " + Math.Round(media, 2));
        }
        /*A dona de um pensionato possui dez quartos para alugar para estudantes,
        sendo esses quartos identificados pelos números 0 a 9.
        Quando um estudante deseja alugar um quarto, deve-se registrar o nome
        e email deste estudante.
        Fazer um programa que inicie com todos os dez quartos vazios, e depois
        leia uma quantidade N representando o número de estudantes que vão
        alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
        N estudantes. Para cada registro de aluguel, informar o nome e email do
        estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
        que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
        um relatório de todas ocupações do pensionato, por ordem de quarto,
        conforme exemplo.*/
        public static void Exercicio03()
        {
            estudantes[] vetor = new estudantes[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = Convert.ToInt32(Console.ReadLine());
                vetor[quarto] = new estudantes(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
    public class estudantes
    {
        public string nome;
        public string email;

        public estudantes(string nome, string email)
        {
            this.nome = nome;
            this.email = email;
        }
    }
}
