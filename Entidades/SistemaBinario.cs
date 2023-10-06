using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(SistemaBinario.NumeroBinarioADecimal(this.valor));
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion devuelve;
            if (ESistema.Binario == sistema)
            {
                devuelve = BinarioADecimal();
            }
            else
            {
                devuelve = this;
            }
            return devuelve;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (!base.EsNumeracionValida(valor))
            {
                return false;
            }
            if (!this.EsSistemaBinarioValido(valor))
            {
                base.msgError = "El numero no es un binario valido";
                return false;
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            if(base.msgError is null)
            {
                return new SistemaDecimal(SistemaBinario.NumeroBinarioADecimal(base.valor));
            }
            return new SistemaDecimal(double.MinValue.ToString());
        }

        public SistemaBinario(string valor) : base(valor) 
        {
        }
        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private static string NumeroBinarioADecimal(string binario)
        {
            char[] arrayBinario = binario.ToCharArray();
            Array.Reverse(arrayBinario);
            int total = 0;
            int aumento = 1;
            foreach (char numerito in arrayBinario)
            {
                string comparar = numerito.ToString();
                if (comparar == "1")
                {
                    total += aumento;
                }
                aumento = aumento * 2;
            }
            return total.ToString();
        }
        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
