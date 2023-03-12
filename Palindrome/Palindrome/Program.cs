using System;

namespace Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra ou frase: ");
            string texto = Console.ReadLine().ToLower();

            // Remover espaços, pontuações e caracteres especiais do texto
            string caracteresInvalidos = ".,:;?!() '\"";
            foreach (char c in caracteresInvalidos)
            {
                texto = texto.Replace(c.ToString(), "");
            }

            // Verificar se o texto é um palíndromo
            bool palindromo = true;
            int i = 0;
            int j = texto.Length - 1;
            while (i < j)
            {
                if (texto[i] != texto[j])
                {
                    palindromo = false;
                    break;
                }
                i++;
                j--;
            }

            // Exibir o resultado
            if (palindromo)
            {
                Console.WriteLine("O texto é um palíndromo!");
            }
            else
            {
                Console.WriteLine("O texto não é um palíndromo.");
            }

            Console.ReadKey();
        }
    }
}
