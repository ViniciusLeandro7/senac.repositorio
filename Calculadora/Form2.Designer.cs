namespace calculadora
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
            rbtnQuadrado = new RadioButton();
            rbtnTriangulo = new RadioButton();
            rbtnRetangulo = new RadioButton();
            label1 = new Label();
            txtLado1 = new TextBox();
            txtLado3 = new TextBox();
            txtLado2 = new TextBox();
            button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // rbtnQuadrado
            // 
            rbtnQuadrado.AutoSize = true;
            rbtnQuadrado.Location = new Point(3, 114);
            rbtnQuadrado.Name = "rbtnQuadrado";
            rbtnQuadrado.Size = new Size(78, 19);
            rbtnQuadrado.TabIndex = 0;
            rbtnQuadrado.TabStop = true;
            rbtnQuadrado.Text = "Quadrado";
            rbtnQuadrado.UseVisualStyleBackColor = true;
            // 
            // rbtnTriangulo
            // 
            rbtnTriangulo.AutoSize = true;
            rbtnTriangulo.Location = new Point(3, 139);
            rbtnTriangulo.Name = "rbtnTriangulo";
            rbtnTriangulo.Size = new Size(74, 19);
            rbtnTriangulo.TabIndex = 1;
            rbtnTriangulo.TabStop = true;
            rbtnTriangulo.Text = "Triângulo";
            rbtnTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbtnRetangulo
            // 
            rbtnRetangulo.AutoSize = true;
            rbtnRetangulo.Location = new Point(3, 164);
            rbtnRetangulo.Name = "rbtnRetangulo";
            rbtnRetangulo.Size = new Size(79, 19);
            rbtnRetangulo.TabIndex = 2;
            rbtnRetangulo.TabStop = true;
            rbtnRetangulo.Text = "Retângulo";
            rbtnRetangulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 252);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(3, 32);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(100, 23);
            txtLado1.TabIndex = 4;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(3, 61);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(100, 23);
            txtLado3.TabIndex = 5;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(119, 32);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(100, 23);
            txtLado2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(140, 69);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // Form2
            // 
            ClientSize = new Size(230, 287);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(txtLado2);
            Controls.Add(txtLado3);
            Controls.Add(txtLado1);
            Controls.Add(label1);
            Controls.Add(rbtnRetangulo);
            Controls.Add(rbtnTriangulo);
            Controls.Add(rbtnQuadrado);
            Name = "Form2";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        private RadioButton rbtnQuadrado;
        private RadioButton rbtnTriangulo;
        private RadioButton rbtnRetangulo;
        private Label label1;
        private TextBox txtLado1;
        private TextBox txtLado3;
        private TextBox txtLado2;
        private Button button1;
        private Label lblResultado;
        
    }
}