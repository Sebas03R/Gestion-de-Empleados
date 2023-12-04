namespace Gestion_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        private string GenerarStringAleatorio(int longitud)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            string randomString = new string(Enumerable.Repeat(caracteres, longitud)
                                                     .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomString;
        }

        public void AgregarElementoListBox(string elemento)
        {
            listBox1.Items.Add(elemento);
        }

        private void Form2_Button1Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();

            form2.ActualizarTextBox3(GenerarStringAleatorio(16));

        }

        internal void Form2_Button1Click()
        {
            button2.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string elementoSeleccionado = listBox1.SelectedItem.ToString();

                string[] partes = elementoSeleccionado.Split(',');

                textBox1.Text = partes[0].Trim();
                textBox2.Text = partes[1].Trim();
                textBox3.Text = partes[2].Trim();
                textBox4.Text = partes[3].Trim();
                textBox5.Text = partes[4].Trim();
            }
            else
            {
                MessageBox.Show("Selecciona un empleado de la lista antes de hacer clic en el botón.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int indiceSeleccionado = listBox1.SelectedIndex;

                listBox1.Items.RemoveAt(indiceSeleccionado);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("Selecciona un elemento de la ListBox antes de hacer clic en el botón.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string elementoSeleccionado = listBox1.SelectedItem.ToString();

                string[] partes = elementoSeleccionado.Split(',');

                textBox1.Text = partes[0].Trim();
                textBox2.Text = partes[1].Trim();
                textBox3.Text = partes[2].Trim();
                textBox4.Text = partes[3].Trim();
                textBox5.Text = partes[4].Trim();

                HabilitarEdicionTextBox(true);
                button1.Enabled = false;
                button3.Enabled = false;
                button1.Visible = false;
                button3.Visible = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Visible = true;
                button6.Visible = true;

            }
            else
            {
                MessageBox.Show("Selecciona un empleado de la lista antes de hacer clic en el botón.");
            }
        }

        private void HabilitarEdicionTextBox(bool habilitar)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void DeshabilitarEdicionTextBox()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int indiceSeleccionado = listBox1.SelectedIndex;

                string nuevoElemento = $"{textBox1.Text}, {textBox2.Text}, {textBox3.Text}, {textBox4.Text}, {textBox5.Text}";
                listBox1.Items[indiceSeleccionado] = nuevoElemento;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                button1.Enabled = true;
                button3.Enabled = true;
                button1.Visible = true;
                button3.Visible = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Visible = false;
                button6.Visible = false;

            }
            else
            {
                MessageBox.Show("Selecciona un elemento de la ListBox antes de hacer clic en el botón.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
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

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button1.Enabled = true;
            button3.Enabled = true;
            button1.Visible = true;
            button3.Visible = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Visible = false;
            button6.Visible = false;
            DeshabilitarEdicionTextBox();
        }
    }
}
