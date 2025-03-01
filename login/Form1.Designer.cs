namespace login
{
    partial class Login
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
            textBoxUsuario = new TextBox();
            textBoxsenha = new TextBox();
            Entrar = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label4 = new Label();
            labelresultado = new Label();
            usuarioc = new TextBox();
            senhac = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(175, 116);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(178, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // textBoxsenha
            // 
            textBoxsenha.Location = new Point(175, 168);
            textBoxsenha.Name = "textBoxsenha";
            textBoxsenha.Size = new Size(178, 23);
            textBoxsenha.TabIndex = 1;
            // 
            // Entrar
            // 
            Entrar.Location = new Point(218, 211);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 2;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(122, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(122, 176);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(555, 248);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 6;
            button2.Text = "Cadastre-se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(231, 51);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "LOGIN ";
            label4.Click += label4_Click;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(122, 344);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 15);
            labelresultado.TabIndex = 8;
            // 
            // usuarioc
            // 
            usuarioc.Location = new Point(474, 116);
            usuarioc.Name = "usuarioc";
            usuarioc.Size = new Size(268, 23);
            usuarioc.TabIndex = 9;
            // 
            // senhac
            // 
            senhac.Location = new Point(474, 168);
            senhac.Name = "senhac";
            senhac.Size = new Size(268, 23);
            senhac.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Usuario:";
            label3.Click += label3_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(474, 150);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 12;
            label5.Text = "Senha:";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 23);
            textBox3.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(474, 194);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "Indicação:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(478, 51);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 15;
            label7.Text = "NOVO USUARIO";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(474, 300);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 15);
            resultado.TabIndex = 16;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 383);
            Controls.Add(resultado);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(senhac);
            Controls.Add(usuarioc);
            Controls.Add(labelresultado);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Entrar);
            Controls.Add(textBoxsenha);
            Controls.Add(textBoxUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox senhac;
        private Button Entrar;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label4;
        private Label labelresultado;
        private TextBox textBoxsenha;
        private TextBox usuarioc;
        private Label label3;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private Label resultado;
    }
}
