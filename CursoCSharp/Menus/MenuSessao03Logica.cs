using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class MenuSessao03Logica
    {
        public static void MenuLogica()
        {
            Linha.Linha_Delimitadora();
            Console.WriteLine("\n" +
               "Qual a categoria do exercicio que deseja realizar? (Digite o numero) \n" +
               " 1 - Sequencial \n" +
               " 2 - Condicional \n" +
               " 3 - While \n" +
               " 4 - For\n" +
               " 5 - Sair\n");
            Linha.Linha_Delimitadora();
        }
    }
}
