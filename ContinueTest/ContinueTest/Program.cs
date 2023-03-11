using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinueTest
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string output = " ";
            string msg = " ";

            for(int count = 0; count<=10; count++)
            {
                if(count <= 6)
                {
                    msg += count + " ";
                    continue;
                }

                output += count + " ";
            }
            output += "\nUsed to continue to skip printing: " + msg;

            MessageBox.Show(output, "Using the Continue statement",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
