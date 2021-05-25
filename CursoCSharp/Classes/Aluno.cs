using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class Aluno
    {
        public string nome;
        public double n1, n2, n3;
        public double media;
        public string situacao;
        public double pontos;

        public void CalcularMedia()
        {
            media = n1 + n2+ n3;

            if(media < 60)
            {
                pontos = 60 - media;
                situacao = "Reprovado. \nFaltaram " + pontos + " pontos";
            }
            else
            {
                situacao = "Aprovado.";
            }
        }
    }
}
