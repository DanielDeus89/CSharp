using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histogram
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int[] n = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 10 };
            string output = "";

            output += "Element\tvalue\tHistogram\n";

            for(int i = 0; i < n.Length; i++)
            {
                output += "\n" + i + "\t" + n[i] + "\t"; 

                for(int j = 1; j <= n[i]; j++)
                {
                    output += "* ";
                }
            }


            MessageBox.Show(output);
        }
    }
}
