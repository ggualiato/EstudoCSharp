using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public abstract class Conta
    {

        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);
        
    }
}
