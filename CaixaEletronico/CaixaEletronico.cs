using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class CaixaEletronico
    {
        private CaixaEletronico()
        { }

        public static CaixaEletronico New()
        {
            return new CaixaEletronico();
        }

        public Saque Sacar(int value)
        {
            int restanteCem;
            var notasDeCem = Math.DivRem(value, 100, out restanteCem);

            int restanteCinquenta;
            var notasDeCinquenta = Math.DivRem(restanteCem, 50, out restanteCinquenta);

            int restanteVinte;
            var notasDeVinte = Math.DivRem(restanteCinquenta, 20, out restanteVinte);

            int restanteDez;
            var notasDDez = Math.DivRem(restanteVinte, 10, out restanteDez);

            return new Saque(notasDDez, notasDeVinte, notasDeCinquenta, notasDeCem);
        }
    }
}
