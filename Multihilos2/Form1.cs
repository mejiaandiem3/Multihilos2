using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Multihilos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            this.Close();
        }

        private void btnprocesos_Click(object sender, EventArgs e)
        {
            //creacion de hilos
            Thread h1 = new Thread(new ThreadStart(Metodo1));
            Thread h2 = new Thread(new ThreadStart(Metodo2));
            Thread h3 = new Thread(new ThreadStart(Metodo3));


            //inicializacion de hilos
            h1.Start();
            h2.Start();
            h3.Start();


            //cierre de hilo
            h1.Join();
            h2.Join();
            h3.Join();

        }

        public void Metodo1()
        {
            for (int i = 0; i < 30; i++)
            {
                this.pictureBox1.Load("i1.JPG");
                Thread.Sleep(300);
                this.pictureBox1.Load("i2.JPG");
                Thread.Sleep(300);
                this.pictureBox1.Load("i3.JPG");
                Thread.Sleep(300);
                this.pictureBox1.Load("i4.JPG");
                Thread.Sleep(300);
                this.pictureBox1.Load("i5.JPG");
                Thread.Sleep(300);
            }


        }

        public void Metodo2()
        {
            for (int i = 0; i < 30; i++)
            {
                this.pictureBox2.Load("i6.JPG");
                Thread.Sleep(300);
                this.pictureBox2.Load("i7.JPG");
                Thread.Sleep(300);
                this.pictureBox2.Load("i8.JPG");
                Thread.Sleep(300);
                this.pictureBox2.Load("i9.JPG");
                Thread.Sleep(300);
                this.pictureBox2.Load("i10.JPG");
                Thread.Sleep(300);
            }


        }

        public void Metodo3()
        {
            for (int i = 0; i < 30; i++)
            {
                this.pictureBox3.Load("i11.JPG");
                Thread.Sleep(300);
                this.pictureBox3.Load("i12.JPG");
                Thread.Sleep(300);
                this.pictureBox3.Load("i13.JPG");
                Thread.Sleep(300);
                this.pictureBox3.Load("i14.JPG");
                Thread.Sleep(300);
                this.pictureBox3.Load("i15.JPG");
                Thread.Sleep(300);
            }

        }



    }
}
