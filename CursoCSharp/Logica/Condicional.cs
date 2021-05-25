using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Condicional
{
    public class Condicional
    {

        public static void MenuCondicional()
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
                    MenuCondicional();
                    break;
            }
           

        }
        /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            int numero;
            Console.WriteLine("Digite um numero inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }
        /*Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            int numero;
            Console.WriteLine("Digite um numero inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("NUMERO PAR");
            }
            else
            {
                Console.WriteLine("NUMERO IMPAR");
            }
        }
        /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        ordem crescente ou decrescente.*/
        public static void Exercicio03()
        {
            Linha.Linha_Delimitadora();
            int a, b;
            Console.WriteLine("Digite um numero inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos.");
            }
        }
        /*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/
        public static void Exercicio04()
        {
            Linha.Linha_Delimitadora();
            int inicial, final, tempo;
            Console.WriteLine("Hora inicial: ");
            inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hora final: ");
            final = Convert.ToInt32(Console.ReadLine());

            if(inicial > final)
            {
                tempo = (24 - inicial) + final;
            }
            else if(final > inicial)
            {
                tempo = final - inicial;
            }
            else
            {
                tempo = 24;
            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORAS");
        }
        /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
        seguir, calcule e mostre o valor da conta a pagar.*/
        public static void Exercicio05()
        {
            Linha.Linha_Delimitadora();
            int cod_pedido, quant_pedido;
            double preco_pedido;
            
            Console.WriteLine("1 - Cachorro Quente\n2 - X-Salada\n3 - X-Bacon\n4 - Torrada Simples\n5 - Refrigerante \nDigite o codigo do item que deseja: \n ");
            cod_pedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade: ");
            quant_pedido = Convert.ToInt32(Console.ReadLine());

            switch (cod_pedido)
            {
                case 1:
                    preco_pedido = 4.0 * quant_pedido;
                    break;
                case 2:
                    preco_pedido = 4.5 * quant_pedido;
                    break;
                case 3:
                    preco_pedido = 5.0 * quant_pedido;
                    break;
                case 4:
                    preco_pedido = 2.0 * quant_pedido;
                    break;
                case 5:
                    preco_pedido = 1.5 * quant_pedido;
                    break;
                default:
                    Console.WriteLine("Digite um código válido.");
                    preco_pedido = 1 * quant_pedido;
                    break;
                
            }
            Console.WriteLine("TOTAL: R$ " + Math.Round(preco_pedido, 2));


        }
        /*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
        nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
        public static void Exercicio06()
        {
            Linha.Linha_Delimitadora();
            double numero;
            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if(numero >= 0 && numero <= 25)
            {
                Console.WriteLine("INTERVALO: [0,25]");
            }
            else if(numero > 25 && numero <= 50)
            {
                Console.WriteLine("INTERVALO: [25,50]");
            }
            else if(numero > 50 && numero <= 75)
            {
                Console.WriteLine("INTERVALO: [50,75]");
            }
            else if(numero > 75 && numero <= 100)
            {
                Console.WriteLine("INTERVALO: [75,100]");            
            }
            else
            {
                Console.WriteLine("FORA DO INVERVALO");
            }
        }
        /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
        que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
        qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
        Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
        mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
       */
        public static void Exercicio07()
        {
            Linha.Linha_Delimitadora();
            double salario, imposto;
            Console.WriteLine("Digite o salario: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 2000)
            {
                imposto = 0;
            }
            else if (salario <= 3000)
            {
                imposto = 0.08 * salario;
            }
            else if (salario <= 4500)
            { 
                imposto = 0.18 * salario;
            }
            else if(salario > 4500)
            {
                imposto = 0.28 * salario;
            }
            else
            {
                imposto = 0;
            }

            Console.WriteLine("O valor de imposto está em R$ " + imposto);
        }
    }
}
