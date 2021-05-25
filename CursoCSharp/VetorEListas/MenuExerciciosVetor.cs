using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.VetorEListas
{
    class MenuExerciciosVetor
    {
        public static void MenuVetorExercicios()
        {
            while (Globais.op != 5)
            {
                MenuSessao06VetoresEListas.MenuVetorELista();
                Globais.op = Convert.ToInt32(Console.ReadLine());
                if (Globais.op == 1)
                {
                    VetorEListas.Vetores.MenuVetores();
                }
                else if (Globais.op == 2)
                {
                    Condicional.Condicional.MenuCondicional();
                }
                else if (Globais.op == 3)
                {
                    While.MenuWhile();
                }
                else if (Globais.op == 4)
                {
                    Limpar.LimparTela();

                    break;
                }
                else
                {
                    Linha.Linha_Delimitadora();
                    Console.WriteLine("Digite um valor valido.");

                }

                Limpar.LimparTela();
            }
        }
    }
}
