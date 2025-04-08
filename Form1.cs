using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroaleatorioKV_5toB
{
    public partial class Form1 : Form
    {
        int intentos = 0; //Inicializar la Variable
        Random rand = new Random(); //Crea eñ objeto que genere el número aleatorio
        int aleatorio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5;
            txtintentos.Text = intentos.ToString();
            aleatorio = rand.Next(1, 100); // aleatorio = número entre 1 y 100

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                if (num == aleatorio)
                {
                    MessageBox.Show($"Gano el juego. El numero es {aleatorio}");
                    DialogResult resultado = MessageBox.Show("¿Quiere volver a jugar?", "Resultado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtintentos.Text = intentos.ToString();
                        aleatorio = rand.Next(1, 100); // aleatorio = número entre 1 y 100cdsfsvfngbbd f ytjf  67jyr f i56tfb54 6tref rg3 4redg 

                    }
                }

                if (num > aleatorio)
                {
                    MessageBox.Show($"{num} es mayor al numero aleatorio");
                }

                if (num < aleatorio)
                {
                    MessageBox.Show($"{num} es menor al numero aleatorio");
                }

            }

        }
    }   
}
