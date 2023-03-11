using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            decimal amount, principal = (decimal)1000.00;
            double rate = 0.05;
            string output = "";

            for(int year = 1; year <=10; year++)
            {
                amount = principal * (decimal)Math.Pow(1.0 + rate, year);
                output += year + "\t" + 
                    String.Format("{0:C}", amount ) + "\n";
            }

            MessageBox.Show(output, "Compound Interest",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
