using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Teste_01_SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar thread 0
            Program.CriarThread(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Criar thread 1
            Program.CriarThread(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Criar thread 2
            Program.CriarThread(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parametros p = new Parametros();
            p.mensagem = textBox1.Text;
            p.index = 0;
            Program.IniciarThread(0, p);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Parametros p = new Parametros();
            p.mensagem = textBox1.Text;
            p.index = 1;
            Program.IniciarThread(1, p);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Parametros p = new Parametros();
            p.mensagem = textBox1.Text;
            p.index = 2;
            Program.IniciarThread(2, p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.PararThread(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.PararThread(1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.PararThread(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.ExcluirThread(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.ExcluirThread(1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.ExcluirThread(2);
        }
    }
}
