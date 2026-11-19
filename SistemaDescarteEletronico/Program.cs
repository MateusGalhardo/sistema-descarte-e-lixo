using System;
using System.Threading;
using System.Windows.Forms;

namespace SistemaDescarteEletronico
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // mutex pro instalador saber se o programa está aberto
            using (Mutex aberto = new Mutex(false, "SistemaDescarteEletronico_Equipe10"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormPrincipal());
            }
        }
    }
}
