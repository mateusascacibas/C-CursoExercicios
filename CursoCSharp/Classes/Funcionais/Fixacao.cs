using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class Fixacao
    {
        public static void MenuFixacao()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\nQual o numero do exercicio que deseja realizar?\n Exercicio 01 \n Exercicio 02 \n Exercicio 03 \n Exercicio 04 \n Para sair digite 0 \n");
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
                default:
                    Console.WriteLine("\nPor favor, digite um numero de opção valido.");
                    Limpar.LimparTela();
                    MenuFixacao();
                    break;
            }
        }
        /*Fazer um programa para ler os valores da largura e altura de um retângulo. Em
        seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
        como mostrado no projeto ao lado.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            Retangulo ret1 = new Retangulo();
            Console.WriteLine("Digite a largura do Retangulo: ");
            ret1.Largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do Retangulo: ");
            ret1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = " + ret1.Area());
            Console.WriteLine("Perimetro = " + ret1.Perimetro());
            Console.WriteLine("Diagonal = " + ret1.Diagonal());
        }
        /*Fazer um programa para ler os dados de um funcionário (nome,
        salário bruto e imposto). Em seguida, mostrar os dados do
        funcionário (nome e salário líquido). Em seguida, aumentar o salário
        do funcionário com base em uma porcentagem dada (somente o
        salário bruto é afetado pela porcentagem) e mostrar novamente os
        dados do funcionário. Use a classe projetada abaixo.*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imposto: ");
            func.imposto = Convert.ToDouble(Console.ReadLine());
            func.SalarioLiquido();
            Console.WriteLine("Funcionario: " + func.nome + ", " + func.Salario_Liquido);
            Console.WriteLine("Digite a porcentagem pra aumentar o salario: ");
            func.porcentagem = Convert.ToDouble(Console.ReadLine());
            func.AumentarSalario(func.porcentagem);
            Console.WriteLine("Dados atualizados: " + func.nome + ", $ " + func.Salario_Liquido);
        }
        /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
        (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
        ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
        este problema.*/
        public static void Exercicio03()
        {
            Linha.Linha_Delimitadora();
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.n1 = Convert.ToDouble(Console.ReadLine());
            aluno.n2 = Convert.ToDouble(Console.ReadLine());
            aluno.n3 = Convert.ToDouble(Console.ReadLine());
            aluno.CalcularMedia();
            Console.WriteLine("Nota final: " + aluno.media);
            Console.WriteLine(aluno.situacao); 
        }
        /*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reias.
         Informar quantos reais a pessoa vai pagar pelos doláres, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dolar.
         Criar uma classe ConversorDeMoeda para ser responsavel pelos calculos.*/
        public static void Exercicio04()
        {
            Linha.Linha_Delimitadora();
            ConversaoMoeda moeda = new ConversaoMoeda();
            Console.Write("Qual a cotação do dólar? ");
            moeda.cotacao = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? ");
            moeda.dolares = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais = " + moeda.ConverterEmReais());
        }
    }   
}
