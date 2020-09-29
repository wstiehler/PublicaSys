using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicaSys.Forms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormInicio());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possivel saltar a lista com valor nulo. Favor Preencher ! Error Log:" + ex.Message);
            }
        }
    }
}
