using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Thread_Teste_01_SO
{
    static class Program
    {
        static Thread[] Threads = new Thread[3];
        static AutoResetEvent[] Events = new AutoResetEvent[3];
        static Form Form1; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            for (int i = 0; i < 3; i++)
                Events[i] = new AutoResetEvent(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static internal void CriarThread(int index)
        {
            //Criar tread no array
            if (Threads[index] != null)
            {
                MessageBox.Show("Processo já foi criado!!!");
            }
            Thread thread = new Thread(Trabalhador);
            Threads[index] = thread;
        }

        static internal void PararThread(int index)
        {
            //Parar thread no array
            if (Threads[index].ThreadState == ThreadState.Suspended)
            {
                MessageBox.Show("Processo Já foi parado!!!");
                return;
            }

            Threads[index].Interrupt();
        }

        static internal void IniciarThread(int index, Parametros p)
        {
            //inicia o thread no array
            if (Threads[index].ThreadState == ThreadState.Running)
            {
                MessageBox.Show("Processo Já foi iniciado!!!");
                return;
            }

            Threads[index].Start((object) p);
        }

        static internal void ExcluirThread(int index)
        {
            //exclui o thread no array
            if (Threads[index].ThreadState == ThreadState.Stopped)
            {
                MessageBox.Show("Processo Já foi excluido!!!");
                return;
            }

            Threads[index] = null;
        }

        static void Trabalhador(object o)
        {
            //laço infinito mostrar messagebox cada dois segundos e encerra em reação ao auto reset event setado
            Parametros p = (Parametros)o;
            while (true)
            {
                MessageBox.Show("Thread" + p.index, p.mensagem);
            }
        }
    }

    class Parametros
    {
        public int index;
        public string mensagem;
        public AutoResetEvent evento;
    }
}
