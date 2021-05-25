using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    public class MenuInicial
    {
        public static void MenuDeInicio()
        {
            Globais.op = 1;
            Globais.op_ex = 0;
            Globais.op_cate = 1;

            Console.WriteLine("" +
                "Qual sessão deseja explorar?\n" +
                "1 - Lógica de Programação \n" +
                "2 - Classes \n" +
                "3 - Construtor \n"+
                "4 - Vetor, Lista e Matriz \n" +
                "5 - Enumerações \n" +
                "0 - Sair\n");
            Linha.Linha_Delimitadora();
        }

    }
}
