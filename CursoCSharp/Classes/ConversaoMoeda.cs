using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class ConversaoMoeda
    {
        public double cotacao, dolares, valor;

        public double ConverterEmReais()
        {
            valor = (cotacao * dolares);
            valor += valor * 0.06;
            return valor;
        }
    }
}
