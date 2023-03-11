using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTest
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
            int count;

            for (count=1; count<=10; count++)
            {
                if (count == 5)
                {
                    break;
                }
                output += count + " ";
            }

            output += "\nBroke out of loop at count = " + count;

            MessageBox.Show(output, "Demostrating the break statement",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
