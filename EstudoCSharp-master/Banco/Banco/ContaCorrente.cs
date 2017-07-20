using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class ContaCorrente : Conta
    {

        public static int totalDeContas = 0;


        public override void Saca(double valor)
        {

            if(valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                this.Saldo -= valor + 0.10;
            }

        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Saldo += valor;
            }

        }

        /*public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }*/
    }
}
