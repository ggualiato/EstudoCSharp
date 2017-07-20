using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributos();
        }

        /*public void Acumula(ContaPoupanca cp)
        {
            Total += cp.CalculaTributo();
        }

        public void Acumula(ContaCorrente cc)
        {
            Total += cc.CalcularTributo();
        }*/

    }
}
