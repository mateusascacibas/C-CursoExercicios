using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Classes
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double imposto;
        public double Salario_Liquido;
        public double porcentagem;

        public double SalarioLiquido()
        {
            Salario_Liquido = salario - imposto;
            return Salario_Liquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario_Liquido += (salario * porcentagem) / 100;
        }
    }
}
