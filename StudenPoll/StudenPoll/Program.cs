using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenPoll
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int[] response = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 
                6, 3, 8, 6, 10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 
                4, 6, 6, 4, 6, 7, 5, 6, 4, 8, 6, 8, 10 };

            int[] frequency = new int[12];
            string output = "";

            for (int answer = 0; answer < response.Length; answer++)
            {
                ++frequency[response[answer]];
            }
            output += "Rating\tFrequency\n";

            for (int rating = 1; rating < frequency.Length; rating++)
            {
                output += rating + "\t" + frequency[rating] + "\n";
            }

            MessageBox.Show(output);
        }
    }
}
