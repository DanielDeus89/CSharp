using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitArray
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string output = "";

            int[] x = new int[10];

            int[] y = { 32, 34, 33, 52, 44, 78, 6, 51, 53, 64, 44, 67, 59 };

            const int ARRAY_SIZE = 10;
            int[] z = new int[ARRAY_SIZE];

            for (int i = 0; i < z.Length; i++)
            {
                z[i] = 2 + 2 * i;
            }
            output = "Subscript\tArray x\tArray y\tArray z\n";

            for(int i = 0; i < ARRAY_SIZE; i++)
            {
                output += i + "\t\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n";
            }


            MessageBox.Show(output,
                "Initializing an array of init Values",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
         }
    }
}
