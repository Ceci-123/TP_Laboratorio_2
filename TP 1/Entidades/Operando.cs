using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region constructor

        /// <summary>
        /// Constructor por defecto de un objeto de tipo Operando, inicializa el numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor de un objeto de tipo Operando, inicializa el numero en el valor pasado como parametro
        /// </summary>
        /// <param name="numero"> Valor del atributo numero</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de un objeto de tipo Operando, inicializa el numero en el valor dado
        /// </summary>
        /// <param name="strNumero">Valor del atributo numero en formato string</param>
        public Operando(string strNumero)
        {
            this.numero = double.Parse(strNumero);

        }

        #endregion

        #region prop
               
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        #endregion

        #region Metodos

        /// <summary>
        /// Convierte un numero binario a decimal
        /// </summary>
        /// <param name="binario">El numero a convertir en tipo string</param>
        /// <returns>Devuelve el numero en decimal, en tipo string</returns>
        public static string BinarioDecimal(string binario)
        {
            int numero;
            string retorno;
            string trimeado;
            trimeado = binario.Trim();

            if (EsBinario(trimeado))
            {
                numero = Convert.ToInt32(trimeado, 2);
                retorno = numero.ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="numero">El numero a convertir</param>
        /// <returns>Devuelve el numero binario en tipo string</returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            int numeroInt;
            numeroInt = Convert.ToInt32(numero);
            if (numeroInt > 0)
            {
                retorno = Convert.ToString(numeroInt, 2);

            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal en binario
        /// </summary>
        /// <param name="strNumero">El numero a convertir</param>
        /// <returns>Devuelve el numero binario</returns>
        public static string DecimalBinario(string strNumero)
        {
            int numero;
            string retorno = "Valor invalido";
            int.TryParse(strNumero, out numero);
            if (numero > 0)
            {
                retorno = Convert.ToString(numero, 2);

            }
            return retorno;
        }

        /// <summary>
        /// Valida si una cadena es un numero binario
        /// </summary>
        /// <param name="binario">La cadena a evaluar</param>
        /// <returns>Devuelve true si la cadena es un numero binario y false si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;
            int acumCaracteres = 0;
            int caracteresValidos = 0;
            string trimeado;
            trimeado = binario.Trim();

            for (int i = 0; i < trimeado.Length; i++)
            {
                if (trimeado[i] == '1' || trimeado[i] == '0')
                {
                    caracteresValidos++;
                    acumCaracteres += caracteresValidos;
                }


            }

            if (caracteresValidos == binario.Length)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool ConsultaBinario(string binario)
        {
            return EsBinario(binario);
        }

        /// <summary>
        /// Valida y convierte una cadena de caracteres a tipo double
        /// </summary>
        /// <param name="strNumero">La cadena a convertir</param>
        /// <returns>Devuelve el numero si pudo convertirla o 0 si no lo logro </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno;

            if (!double.TryParse(strNumero, out retorno))
            {
                retorno = 0;
            }

            return retorno;
        }
        #endregion

        #region sobrecargas

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;

        }
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;

        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;

        }
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno = 0;
            if (n2.numero != 0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }

            return retorno;

        }
        #endregion
    }
}
