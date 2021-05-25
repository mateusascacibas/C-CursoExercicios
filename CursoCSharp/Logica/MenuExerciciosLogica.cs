using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Logica
{
    class MenuExerciciosLogica
    {
        public static void MenuLogicaExercicios()
        {
            while (Globais.op != 5)
            {
                MenuSessao03Logica.MenuLogica();
                Globais.op = Convert.ToInt32(Console.ReadLine());
                if (Globais.op == 1)
                {
                    Sequencial.Sequencial.MenuSequencial();
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
                    For.MenuFor();
                }
                else if(Globais.op == 5)
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
