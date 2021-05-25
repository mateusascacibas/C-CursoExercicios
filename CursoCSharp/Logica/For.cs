using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class For
    {
       

        public static void MenuFor()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Exercicio 03 \n Exercicio 04 \n Exercicio 05 \n Exercicio 06 \n Exercicio 07 \n Para sair digite 0 \n");
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
                case 4:
                    Exercicio04();
                    break;
                case 5:
                    Exercicio05();
                    break;
                case 6:
                    Exercicio06();
                    break;
                case 7:
                    Exercicio07();
                    break;
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuFor();
                    break;
            }
        }
        /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
        X, se for o caso.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            int X, i;
            Console.WriteLine("Digite o numero: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for(i=1; i <= X; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
        essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            int n, i, dentro = 0, fora = 0, num;
            Console.WriteLine("Digite o numero de vezes que você irá fazer o exercicio: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (i=0; i < n; i++)
            {
                Console.WriteLine("Digite um numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num >= 10 && num <= 20)
                {
                   dentro += 1; 
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine("\n " + dentro + " Dentro do invervalo \n " + fora + " Fora do intervalo");

        }
        /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
        de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
        conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
        peso 5.*/
        public static void Exercicio03()
        {
            Linha.Linha_Delimitadora();
            int n_teste, i, j, k;
            double[] medias;
            double[] notas;
            notas = new double[3];
           
            Console.WriteLine("Digite o numero de testes: (Cada teste tem 3 notas) \n");
            n_teste = Convert.ToInt32(Console.ReadLine());
            medias = new double[n_teste];

            for (i = 0; i < n_teste; i++)
            {
                Console.WriteLine("\nTeste " + (i + 1) + "");
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite a nota " + (j + 1) + ": ");
                    notas[j] = Convert.ToDouble(Console.ReadLine());
                   
                }

                medias[i] = ((notas[0] * 2) + (notas[1] * 3) + (notas[2] * 5)) / 10;
            }

            for(k = 0; k < 3; k++)
            {
                Console.WriteLine("\n Média " + (k + 1) + " é de: " + Math.Round(medias[k], 1));
            }
        }
        /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
        segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/
        public static void Exercicio04()
        {
            Linha.Linha_Delimitadora();
            double saida;
            int n, i;
            double p1, p2;
            Console.WriteLine("Digite o numero de tentativas:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i= 0; i < n; i++)
            {
                Console.WriteLine("Digite o primeiro numero: ");
                p1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                p2 = Convert.ToDouble(Console.ReadLine());
                
                if(p2 == 0)
                {
                    Console.WriteLine("\nDivisão impossivel.");
                }
                else {
                    saida = p1 / p2;
                    Console.WriteLine("\n" + saida);
                }
                Console.WriteLine("\n");
               
            }
        }
        /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
        Lembrando que, por definição, fatorial de 0 é 1.*/
        public static void Exercicio05()
        {
            Linha.Linha_Delimitadora();
            int n, fatorial = 1, i;
            Console.WriteLine("Digite um numero e obtenha o fatorial: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= n; i++)
            {
                fatorial = fatorial * i; 
            }
            Console.WriteLine("O fatorial de " + n + " é " + fatorial);
        }
        /*Ler um número inteiro N e calcular todos os seus divisores.*/
        public static void Exercicio06()
        {
            Linha.Linha_Delimitadora();
            int n, i;
            Console.WriteLine("Digite um numero e obtenha seus divisores: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for(i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
        começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.*/
        public static void Exercicio07()
        {
            Linha.Linha_Delimitadora();
            int n, i;
            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for(i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + i*i + " " + i*i*i);
            }
        }
    }
}
