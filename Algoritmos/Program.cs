using System;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            ///a. Escriba un algoritmo que imprima los números del 1 al 100, pero con las siguientes. Consideraciones:
            ///    Si el número es divisible por 3, se debe imprimir “Bin”
            ///    Si el número es divisible por 5, se debe imprimir “Go”
            ///    Si se cumplen ambas condiciones(divisible por 3 y por 5), se debe imprimir  “Bingo!”
            Bingo();
            ///b.Escriba un algoritmo para calcular e imprimir los primeros 50 números primos.
            NumerosPrimos(50);
            ///c.Dada una cadena de texto compuesta por n palabras separadas por espacio(n > 1), escriba un algoritmo para escribir las palabras de la cadena en orden inverso.
            /// Asuma la cadena como un array de caracteres. Ejemplo: Input: “prueba de lógica”, Output: “lógica de prueba”
            string cadena = "prueba de lógica";
            InversorDeCadenaPorEspacios(cadena);
        }


        public static void Bingo()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("Bingo!");
                else if (i % 3 == 0) Console.WriteLine("Bin");
                else if (i % 5 == 0) Console.WriteLine("Go");
                else Console.WriteLine(i);
            }        
        }

        public static void NumerosPrimos(int objetivo) {
            int numero = 2;
            int numerosPrimosEncontrados = 0;

            while (numerosPrimosEncontrados < objetivo)
            {
                bool esPrimo = true;

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(numero);
                    numerosPrimosEncontrados++;
                }

                numero++;
            }
        }

        public static void InversorDeCadenaPorEspacios(string cadena)
        {
            string[] cadenaDividida = cadena.Split(' ');

            for (int i = cadenaDividida.Length -1; i >= 0; i--)
            {
                Console.WriteLine(cadenaDividida[i]);            
            }            
        }
    }
}
