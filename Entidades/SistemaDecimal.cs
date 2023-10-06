using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(base.valor);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion devuelve;
            if (ESistema.Binario == sistema)
            {
                devuelve = this.DecimalABinario();
            }
            else
            {
                devuelve = this;
            }
            return devuelve;
        }

        public SistemaDecimal(string valor) : base(valor)
        {
        }

        private SistemaBinario DecimalABinario()
        {

            if (!(base.msgError is null) || this.ValorNumerico < 0)
            { 
                return new SistemaBinario(double.MinValue.ToString());
                
            }else
            {
                return new SistemaBinario(SistemaDecimal.NumeroDecimalABinario(this.ValorNumerico));
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (!base.EsNumeracionValida(valor))
            {
                return false;
            }
            if (!this.EsSistemaDecimalValido(valor))
            {
                this.msgError = "El numero no es un decimal valido";
                return false;
            }
            return true;
        }
        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double resultado);
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }
        public static string NumeroDecimalABinario(double numeroConComa)
        {
            int numero = (int)numeroConComa;
            if (numero == 0)
            {
                return "0";
            }
            StringBuilder binario = new StringBuilder();
            int largoTotal = 1;
            int numeroResta = 1;
            while (numero >= numeroResta * 2)
            {
                largoTotal++;
                numeroResta *= 2;
            }
            numero -= numeroResta;
            binario.Append('1');
            while (numero > 0)
            {
                numeroResta = numeroResta / 2;
                if (numeroResta <= numero)
                {
                    binario.Append('1');
                    numero -= numeroResta;
                }
                else
                {
                    binario.Append('0');
                }
            }
            int cerosFinales = binario.Length;
            while (cerosFinales < largoTotal)
            {
                binario.Append('0');
                cerosFinales++;
            }
            return binario.ToString();
        }
    }
}
