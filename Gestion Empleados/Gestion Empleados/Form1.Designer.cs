namespace Gestion_Empleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(356, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(232, 139);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 1;
            label3.Text = "Identificador:";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Tasa Salarial:";
            label4.Click += label1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 133);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 1;
            label5.Text = "Horas a Trabajar:";
            label5.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(72, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(72, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(112, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(112, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 23);
            textBox4.TabIndex = 2;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(112, 125);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 23);
            textBox5.TabIndex = 2;
            textBox5.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(90, 160);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 3;
            button1.Text = "Agregar nuevo empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(9, 160);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(269, 160);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(180, 160);
            button3.Name = "button3";
            button3.Size = new Size(84, 23);
            button3.TabIndex = 3;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(90, 160);
            button5.Name = "button5";
            button5.Size = new Size(84, 23);
            button5.TabIndex = 3;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(180, 160);
            button6.Name = "button6";
            button6.Size = new Size(84, 23);
            button6.TabIndex = 3;
            button6.Text = "Confirmar";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 190);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}
