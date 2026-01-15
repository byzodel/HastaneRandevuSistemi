using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HastaneRandevuSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // PROGRAMIN BAŞLAYACAĞI FORM BURADA TANIMLANIR:
            Application.Run(new Form1());
        }
    }
}
