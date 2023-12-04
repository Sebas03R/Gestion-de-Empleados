using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Gestion_Empleados
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text))
            {
                string elemento = $"{textBox1.Text}, {textBox2.Text}, {textBox3.Text}, {textBox4.Text}, {textBox5.Text}";

                form1.AgregarElementoListBox(elemento);

                form1.Form2_Button1Click();
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener información.");
            }
        }


        public void ActualizarTextBox3(string nuevoTexto)
        {
            textBox3.Text = nuevoTexto;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int numero))
            {
                if (textBox5.Text.Length > 3)
                {
                    textBox5.Text = textBox5.Text.Substring(0, 3);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.Text = textBox5.Text.Substring(0, textBox5.Text.Length - 1);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string contenido = textBox4.Text;

            contenido = new string(contenido.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(contenido))
            {
                if (long.TryParse(contenido, out long numero))
                {
                    string formatoDeseado = string.Format("{0:C0}", numero);

                    textBox4.Text = formatoDeseado;
                }
                else
                {
                    textBox4.Text = contenido.Substring(0, contenido.Length - 1);
                }
            }
            else
            {
                textBox4.Text = "$";
            }

            textBox4.SelectionStart = textBox4.Text.Length;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoActual = textBox1.Text;

            foreach (char caracter in textoActual)
            {
                if (!char.IsLetter(caracter))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.IndexOf(caracter), 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textoActual = textBox1.Text;

            foreach (char caracter in textoActual)
            {
                if (!char.IsLetter(caracter))
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.IndexOf(caracter), 1);
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
        }
    }
}
