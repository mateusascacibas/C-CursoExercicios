using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class MenuExerciciosClasse
    {
        public static void MenuClasseExercicios()
        {
            while (Globais.op != 3)
            {
                Menus.MenuSessao04Classes.MenuClasses();

                Globais.op = Convert.ToInt32(Console.ReadLine());

                if (Globais.op == 1)
                {
                    Introducao.MenuIntroducao();
                }
                else if (Globais.op == 2)
                {
                    Fixacao.MenuFixacao();
                }
                else if (Globais.op == 3)
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
