namespace CRUD_13_VB_31_Marzo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(160, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 516);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(203, 90);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(595, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(595, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 39);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(636, 165);
            button2.Name = "button2";
            button2.Size = new Size(268, 46);
            button2.TabIndex = 3;
            button2.Text = "GENERAR DINAMICO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(677, 316);
            button3.Name = "button3";
            button3.Size = new Size(179, 68);
            button3.TabIndex = 4;
            button3.Text = "CONSULTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(677, 409);
            button4.Name = "button4";
            button4.Size = new Size(179, 68);
            button4.TabIndex = 4;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(677, 503);
            button5.Name = "button5";
            button5.Size = new Size(179, 68);
            button5.TabIndex = 4;
            button5.Text = "SUMA";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(677, 596);
            button6.Name = "button6";
            button6.Size = new Size(179, 68);
            button6.TabIndex = 4;
            button6.Text = "ORDENAR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 813);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}