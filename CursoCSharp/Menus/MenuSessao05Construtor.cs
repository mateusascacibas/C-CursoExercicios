using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Menus
{
    class MenuSessao05Construtor
    {
        public static void MenuConstrutor()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\n" +
               "Qual a categoria do exercicio que deseja realizar? (Digite o numero) \n" +
               " 1 - Fixação \n" +
               " 2 - Sair \n");
            Linha.Linha_Delimitadora();
        }
    }
}
