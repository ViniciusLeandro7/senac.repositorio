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
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            labelresultado = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 282);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 5;
            label3.Text = "Esqueci a senha :";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 278);
            button2.Name = "button2";
            button2.Size = new Size(110, 23);
            button2.TabIndex = 6;
            button2.Text = "Redefinir senha";
            button2.UseVisualStyleBackColor = true;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 383);
            Controls.Add(labelresultado);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
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
        private TextBox textBox2;
        private Button Entrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label labelresultado;
        private TextBox textBoxsenha;
    }
}
