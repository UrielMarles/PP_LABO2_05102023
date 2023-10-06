using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ESistema {Decimal,Binario}
    public abstract class Numeracion
    {
        protected string? msgError;
        protected string valor;

        public string Valor
        {
            get
            {
                if(this.valor == double.MinValue.ToString())
                {
                    return "Error: no se puede mostrar el valor";
                }
                return this.valor;
            }
        }
        internal abstract double ValorNumerico
        {
            get;
        }

        static Numeracion()
        {
        }
        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            if (valor is null || valor.Contains(" ") || valor == double.MinValue.ToString())
            {
                this.msgError = "El numero no es valido";
                return false;
            }
            return true;
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }else
            {
                this.valor = double.MinValue.ToString();
            }
            
        }

        public static explicit operator double(Numeracion num)
        {
            return num.ValorNumerico;
        }

        public static bool operator ==(Numeracion num1,Numeracion num2)
        {
            object obj1 = num1;
            object obj2 = num2;
            if (num1 is null || num2 is null || obj1.GetType() != obj2.GetType())
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Numeracion num1,Numeracion num2)
        {
            return !(num1 == num2);
        }



    }
}
