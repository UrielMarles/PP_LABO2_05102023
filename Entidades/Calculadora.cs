using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        static ESistema sistema;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public static ESistema Sistema
        {
            get { return Calculadora.sistema; }
            set { Calculadora.sistema = value; }
        }

        static Calculadora()
        {

        }
        public Calculadora()
        {
       
        }
        public Calculadora(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
            this.operaciones = new List<string>();
        }

        public void Calcular()
        {
            Calcular('+');
        }
        public void Calcular(char operador)
        {
            if (this.primerOperando != this.segundoOperando || this.primerOperando.Valor == double.MinValue.ToString() || this.segundoOperando.Valor == double.MinValue.ToString())
            {
                this.resultado = MapeaResultado(double.MinValue);
            }
            else
            {
                double n1 = primerOperando.ValorNumerico;
                double n2 = primerOperando.ValorNumerico;
                switch (operador) 
                {
                    case '+':
                        this.resultado = MapeaResultado(n1 + n2);
                        break;
                    case '-':
                        this.resultado = MapeaResultado(n1 - n2);
                        break;
                    case '*':
                        this.resultado = MapeaResultado(n1 * n2);
                        break;
                    case '/':
                        if (n2 == 0)
                        {
                            this.resultado = MapeaResultado(double.MinValue);
                        }
                        else
                        {
                            this.resultado = MapeaResultado(n1 / n2);
                        }
                        break;
                }
            }
        }
        private Numeracion MapeaResultado(double valor)
        {
            if(Calculadora.sistema == ESistema.Decimal)
            {
                return new SistemaDecimal(valor.ToString());
            }
            string valBin = SistemaDecimal.NumeroDecimalABinario(valor);
            return new SistemaBinario(valBin);

        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(sistema.ToString());
            sb.Append(' ');
            sb.Append(this.primerOperando.Valor);
            sb.Append(' ');
            sb.Append(operador);
            sb.Append(' ');
            sb.Append(this.segundoOperando.Valor);
            this.operaciones.Add(sb.ToString());
        }
        public void EliminarHistorialDeOperaciones() 
        {
            this.operaciones = new List<string>();
        }

    }
}
