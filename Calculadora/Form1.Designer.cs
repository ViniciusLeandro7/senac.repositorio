namespace calculadora
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
            Calcular = new Button();
            label1 = new Label();
            valor2 = new TextBox();
            valor1 = new TextBox();
            Resultado = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Menu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            formatosQRToolStripMenuItem = new ToolStripMenuItem();
            Soma = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            button4 = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(90, 302);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(94, 33);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "CALCULADORA";
            label1.Click += label1_Click;
            // 
            // valor2
            // 
            valor2.Location = new Point(12, 106);
            valor2.Name = "valor2";
            valor2.Size = new Size(121, 23);
            valor2.TabIndex = 5;
            // 
            // valor1
            // 
            valor1.Location = new Point(12, 62);
            valor1.Name = "valor1";
            valor1.Size = new Size(121, 23);
            valor1.TabIndex = 6;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(141, 95);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(21, 15);
            Resultado.TabIndex = 7;
            Resultado.Text = "  =";
            // 
            // button1
            // 
            button1.Location = new Point(81, 389);
            button1.Name = "button1";
            button1.Size = new Size(33, 33);
            button1.TabIndex = 8;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 389);
            button2.Name = "button2";
            button2.Size = new Size(33, 33);
            button2.TabIndex = 9;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(42, 389);
            button3.Name = "button3";
            button3.Size = new Size(33, 33);
            button3.TabIndex = 10;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(299, 24);
            Menu.TabIndex = 11;
            Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, formatosQRToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // formatosQRToolStripMenuItem
            // 
            formatosQRToolStripMenuItem.Name = "formatosQRToolStripMenuItem";
            formatosQRToolStripMenuItem.Size = new Size(180, 22);
            formatosQRToolStripMenuItem.Text = "Formatos Q/R";
            formatosQRToolStripMenuItem.Click += formatosQRToolStripMenuItem_Click;
            // 
            // Soma
            // 
            Soma.AutoSize = true;
            Soma.Location = new Point(6, 160);
            Soma.Name = "Soma";
            Soma.Size = new Size(55, 19);
            Soma.TabIndex = 12;
            Soma.TabStop = true;
            Soma.Text = "Soma";
            Soma.UseVisualStyleBackColor = true;
            Soma.CheckedChanged += Soma_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 185);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Subtração";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 210);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(97, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Multiplicação";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 235);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 19);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Divisão";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 80);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 16;
            label2.Text = "   ";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(120, 389);
            button4.Name = "button4";
            button4.Size = new Size(30, 33);
            button4.TabIndex = 17;
            button4.Text = " +";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 450);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(Soma);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(valor1);
            Controls.Add(valor2);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "Form1";
            Text = "Calcular";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calcular;
        private Button button2;
        private Label label1;
        private TextBox valor2;
        private TextBox valor1;
        private Label Resultado;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private MenuStrip Menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private RadioButton Soma;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private Button button4;
        private ToolStripMenuItem formatosQRToolStripMenuItem;
    }
}
