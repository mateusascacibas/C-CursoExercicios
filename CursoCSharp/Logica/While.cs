using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class While
    {
        public static void MenuWhile()
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
                    MenuWhile();
                    break;
            }
        }
        /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
        incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
        public static void Exercicio01()
        {
            Linha.Linha_Delimitadora();
            int senha = 0;
            while (senha != 2002)
            {
                Console.WriteLine("\nDigite a senha: ");
                senha = Convert.ToInt32(Console.ReadLine());
                if (senha == 2002)
                {
                    Console.WriteLine("Acesso permitido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }

            }
        }
        /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
        um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
        4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
        que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
        mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
        exemplo.*/
        public static void Exercicio02()
        {
            Linha.Linha_Delimitadora();
            int codigo = 0;
            int alcool = 0, gasolina = 0, diesel = 0;

            while(codigo != 4)
            {

                Console.WriteLine("\n1.Alcool \n2.Gasolina \n3.Diesel \n4.Fim");
                codigo = Convert.ToInt32(Console.ReadLine());
                
                switch (codigo)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n Muito Obrigado.\n" +
                "Alcool: " + alcool +
                "\nGasolina: " + gasolina +
                "\nDiesel: " + diesel);
            
        }
    }
}

