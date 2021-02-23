using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoRafael.View;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafael {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            
        }
    }
}
