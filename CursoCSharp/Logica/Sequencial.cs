using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Sequencial
{
    public class Sequencial
    {

        public static void MenuSequencial()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Exercicio 03 \n Exercicio 04 \n Exercicio 05 \n Exercicio 06 \n Para sair digite 0\n");
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
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuSequencial();
                    break;
            }
        }
        /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        mensagem explicativa, conforme exemplos.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            int n1, n2, soma;
            Console.WriteLine("Digite um numero inteiro: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero inteiro: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("\nSOMA = " + soma);
        }

        /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        casas decimais conforme exemplos.*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            double raio, area;
            Console.WriteLine("Digite o raio do circulo: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * (raio * raio);
            Console.WriteLine("\nA = " + Math.Round(area, 4));
        }

        /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        e A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
        public static void Exercicio03()
        {
            Linha.Linha_Delimitadora();
            int a, b, c, d, resultado;
            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            d = Convert.ToInt32(Console.ReadLine());
            resultado = (a * b - c * d);
            Console.WriteLine(" \n DIFERENÇA: " + resultado);
        }

        /*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
        decimais.*/
        public static void Exercicio04(){
            Linha.Linha_Delimitadora();
            double horas, valor_por_hora, salario, id;
            Console.WriteLine("Digite o numero (ID) do funcionario: ");
            id = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite suas horas trabalhadas: ");
            horas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor que ganha por hora: ");
            valor_por_hora = Convert.ToDouble(Console.ReadLine());
            salario = horas * valor_por_hora;
            Console.WriteLine("\nNumero do funcionario: " + id);
            Console.WriteLine("Salario: R$ " + Math.Round(salario, 2));
        }
        /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
        public static void Exercicio05(){
            Linha.Linha_Delimitadora();
            int codigop1, numerop1, codigop2, numerop2;
            double valorp1, valorp2, valor_totalp1, valor_totalp2, valor_total;
            Console.WriteLine("Digite o codigo da peça 01: ");
            codigop1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 01: ");
            numerop1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 01: ");
            valorp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o codigo da peça 02: ");
            codigop2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero de peças 02: ");
            numerop2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor unitário da peça 02: ");
            valorp2 = Convert.ToDouble(Console.ReadLine());
            valor_totalp1 = numerop1 * valorp1;
            valor_totalp2 = numerop2 * valorp2;
            valor_total = valor_totalp1 + valor_totalp2;
            Console.WriteLine("\nVALOR A PAGAR: " + Math.Round(valor_total, 2));
        }

        /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
        mostre:
        a) a área do triângulo retângulo que tem A por base e C por altura.
        b) a área do círculo de raio C. (pi = 3.14159)
        c) a área do trapézio que tem A e B por bases e C por altura.
        d) a área do quadrado que tem lado B.
        e) a área do retângulo que tem lados A e B.*/
        public static void Exercicio06()
        {
            Linha.Linha_Delimitadora();
            double a, b, c, area_tri, area_circ, area_trape, area_quadr, area_ret;

            Console.WriteLine("Digite o valor do ponto A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do ponto B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do ponto C: ");
            c = Convert.ToDouble(Console.ReadLine());
            area_tri = (a * c) / 2;
            area_circ = 3.14159 * (c * c);
            area_trape = ((a + b) / 2) * c;
            area_quadr = b * b;
            area_ret = a * b;
            Console.WriteLine("\nTRIANGULO: " + Math.Round(area_tri, 3));
            Console.WriteLine("CIRCULO: " + Math.Round(area_circ, 3));
            Console.WriteLine("TRAPEZIO: " + Math.Round(area_trape, 3));
            Console.WriteLine("QUADRADO: " + Math.Round(area_quadr, 3));
            Console.WriteLine("RETANGULO: " + Math.Round(area_ret, 3));
        }
    }
}
