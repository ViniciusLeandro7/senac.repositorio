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
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(129, 112);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(33, 33);
            Calcular.TabIndex = 0;
            Calcular.Text = "+";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "CALCULADORA";
            label1.Click += label1_Click;
            // 
            // valor2
            // 
            valor2.Location = new Point(203, 62);
            valor2.Name = "valor2";
            valor2.Size = new Size(127, 23);
            valor2.TabIndex = 5;
            // 
            // valor1
            // 
            valor1.Location = new Point(12, 62);
            valor1.Name = "valor1";
            valor1.Size = new Size(141, 23);
            valor1.TabIndex = 6;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(12, 222);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(192, 15);
            Resultado.TabIndex = 7;
            Resultado.Text = "insira valores para realizar o calculo";
            // 
            // button1
            // 
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.Size = new Size(33, 33);
            button1.TabIndex = 8;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 112);
            button2.Name = "button2";
            button2.Size = new Size(33, 33);
            button2.TabIndex = 9;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(90, 112);
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
            Menu.Size = new Size(470, 24);
            Menu.TabIndex = 11;
            Menu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem });
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
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
    }
}
