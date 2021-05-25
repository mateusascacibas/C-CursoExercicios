using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class Limpar
    {
        public static void LimparTela()
        {
            Console.WriteLine("Aperte alguma tecla para confirmar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
