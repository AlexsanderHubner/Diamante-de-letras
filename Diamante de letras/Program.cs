using System;

namespace Diamante_de_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] letra = alfabeto.ToCharArray();
            int indice = 1;
            Console.WriteLine("Magrão me da uma letra: ");
            char letraEscolhida = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < letra.Length; i++)
            {
                if (letraEscolhida == letra[i])
                {

                    indice += Array.IndexOf(letra, letraEscolhida);

                    for (int j = 0; j < indice; j++)
                    {
                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int n = 0; n < 1; n++)
                        {
                            Console.Write(letra[j]);

                            for (int l = 0; l <= 2 * j - 2; l++)
                            {
                                Console.Write(" ");
                            }
                            if (j != n)
                            {
                                Console.Write(letra[j]);
                            }
                            Console.WriteLine();

                        }

                    }
                    for (int j = indice - 2; j > -1; j--)
                    {
                        for (int k = 0; k < indice - j; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int n = 0; n < 1; n++)
                        {
                            Console.Write(letra[j]);

                            for (int l = 0; l <= 2 * j - 2; l++)
                            {
                                Console.Write(" ");
                            }
                            if (j != n)
                            {
                                Console.Write(letra[j]);
                            }
                            Console.WriteLine();

                        }
                    }


                }
            }
        }

    }
}