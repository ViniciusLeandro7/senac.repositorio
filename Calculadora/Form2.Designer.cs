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
            perimetro = new TextBox();
            volume = new TextBox();
            textBox3 = new TextBox();
            area = new TextBox();
            label1 = new Label();
            Calcular = new Button();
            resultado = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            radioButton4 = new RadioButton();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // perimetro
            // 
            perimetro.Location = new Point(11, 79);
            perimetro.Name = "perimetro";
            perimetro.Size = new Size(66, 23);
            perimetro.TabIndex = 0;
            perimetro.TextChanged += textBox1_TextChanged;
            // 
            // volume
            // 
            volume.Location = new Point(94, 79);
            volume.Name = "volume";
            volume.Size = new Size(66, 23);
            volume.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(66, 23);
            textBox3.TabIndex = 2;
            // 
            // area
            // 
            area.Location = new Point(176, 79);
            area.Name = "area";
            area.Size = new Size(66, 23);
            area.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(136, 355);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(106, 37);
            Calcular.TabIndex = 5;
            Calcular.Text = "calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(131, 127);
            resultado.Name = "resultado";
            resultado.Size = new Size(59, 15);
            resultado.TabIndex = 6;
            resultado.Text = "Resultado";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(11, 209);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Area";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 234);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perimetro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 284);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Volume";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 14);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 13;
            label2.Text = "Calculadora Quadrado Retangulo";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 259);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(comboBox1);
            Controls.Add(radioButton4);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(resultado);
            Controls.Add(Calcular);
            Controls.Add(label1);
            Controls.Add(area);
            Controls.Add(textBox3);
            Controls.Add(volume);
            Controls.Add(perimetro);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox perimetro;
        private TextBox volume;
        private TextBox textBox3;
        private TextBox area;
        private Label label1;
        private Button Calcular;
        private Label resultado;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private RadioButton radioButton4;
        private ComboBox comboBox1;
    }
}