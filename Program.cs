using System;


namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 5, 8, 4, 10, 6, 22, 1, 7, 9, 2 };
            menorAMayor(numeros);

        }

        private static void menorAMayor(int[] numeros)
        {
            int i, j, aux;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }


                }
            }
            foreach (int x in numeros)
            {
                Console.WriteLine(x);
            }
        }
    }


}