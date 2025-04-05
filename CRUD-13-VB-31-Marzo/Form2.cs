using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_13_VB_31_Marzo
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        int[] numeros;
        int tam;

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[10];
            Random x = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = x.Next(100) + 1;
                listBox1.Items.Add(numeros[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tam = int.Parse(textBox1.Text);
            numeros = new int[tam];
            Random x = new Random();
            for (int i = 0;i < numeros.Length;i++)
            {
                numeros[i] = x.Next(100) + 1;
                listBox1.Items.Add("Arreglo ["+"] =" + numeros[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(textBox2.Text);
            MessageBox.Show("El elemento del arreglo es " + numeros[pos]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int menor = numeros[0];
            int mayor = 0;
            for(int i = 0; i<numeros.Length; i++) 
            { 
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }
            MessageBox.Show("Menor: " + menor);
            MessageBox.Show("Mayor: " +mayor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i<numeros.Length; i++)
            {
                suma = suma + numeros[i];
            }
            MessageBox.Show("La suma de todos los elementos es: " + suma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int aux;
            for(int i = 0; i < tam - 1; i++)
            {
                for(int j = 0; j < tam - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j+1];
                        numeros[j+1] = aux;
                    }
                }
            }
            for (int i = 0;i < tam;i++) 
            {
                listBox1.Items.Add("Arreglo[" + i + "] = " + numeros[i]);
            }
        }
    }
}
