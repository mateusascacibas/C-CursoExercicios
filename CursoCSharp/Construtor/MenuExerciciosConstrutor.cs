using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Construtor
{
    class MenuExerciciosConstrutor
    {
        public static void MenuConstrutorExercicios()
        {
            while (Globais.op != 2)
            {
                Menus.MenuSessao05Construtor.MenuConstrutor();
                Globais.op = Convert.ToInt32(Console.ReadLine());
                if (Globais.op == 1)
                {
                    Construtor.MenuConstrutor();
                }
                else if (Globais.op == 2)
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
