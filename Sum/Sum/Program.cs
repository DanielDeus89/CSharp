using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int sum = 0;

            for (int counter = 1; counter <= 100; counter+=2)
            {
                sum += counter;
            }

            MessageBox.Show("The sum is " + sum,
                "Sum Even Integers from 2 to 100",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
