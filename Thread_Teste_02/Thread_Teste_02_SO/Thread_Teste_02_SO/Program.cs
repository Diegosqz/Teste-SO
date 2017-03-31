using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Thread_Teste_02_SO
{
    static class Program
    {
        static Queue<string> lista;
        static Thread[] threads = new Thread[2];
        static AutoResetEvent[] reset = new AutoResetEvent[2];
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            lista = new Queue<string>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void iniciar_B()
        {
            threads[0] = new Thread(B);
            threads[0].Start();
        }
        public static void iniciar_C()
        {
            threads[1] = new Thread(C);
            threads[1].Start();

        }
        public static void B()
        {

        }
        public static void C()
        {
            Application.Run(new Form2());

        }


    }
    public class informacao
    {
        public AutoResetEvent AutoReset;
    }
}
