using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Construtor
{
    public class Banco
    {
        private string Nome;
        public  int contador = 1;
        private int numero_conta;
        private double saldo = 0;

        public Banco(string Nome, double saldo)
         {
            this.Nome = Nome ;
            this.numero_conta = this.contador;
            this.contador += 1;
            this.saldo = saldo;
         }
        public string Name
        {
            get
            {
                return Nome;
            }

            set
            {
                this.Nome = value;
            }
        }

        public int NumeroConta
        {
            get
            {
                return numero_conta;
            }

        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

        }

        public double Saque
        {
            set 
            {
                this.saldo = (this.saldo - value) - 5;
            }
        }

        public double Deposito
        {
            set
            {
                this.saldo = this.saldo + value;
            }
        }
    }
}
