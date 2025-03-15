namespace calculadora
{
    partial class Form3
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
            btnCalcular = new Button();
            txtRaio = new TextBox();
            rbtnDiametro = new RadioButton();
            rbtnPerimetro = new RadioButton();
            rbtnArea = new RadioButton();
            rbtnVolume = new RadioButton();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(7, 189);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 27);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(108, 32);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(109, 23);
            txtRaio.TabIndex = 5;
            // 
            // rbtnDiametro
            // 
            rbtnDiametro.AutoSize = true;
            rbtnDiametro.Location = new Point(8, 82);
            rbtnDiametro.Name = "rbtnDiametro";
            rbtnDiametro.Size = new Size(74, 19);
            rbtnDiametro.TabIndex = 6;
            rbtnDiametro.TabStop = true;
            rbtnDiametro.Text = "Diametro";
            rbtnDiametro.UseVisualStyleBackColor = true;
            // 
            // rbtnPerimetro
            // 
            rbtnPerimetro.AutoSize = true;
            rbtnPerimetro.Location = new Point(8, 107);
            rbtnPerimetro.Name = "rbtnPerimetro";
            rbtnPerimetro.Size = new Size(77, 19);
            rbtnPerimetro.TabIndex = 7;
            rbtnPerimetro.TabStop = true;
            rbtnPerimetro.Text = "Perimetro";
            rbtnPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbtnArea
            // 
            rbtnArea.AutoSize = true;
            rbtnArea.Location = new Point(8, 132);
            rbtnArea.Name = "rbtnArea";
            rbtnArea.Size = new Size(49, 19);
            rbtnArea.TabIndex = 8;
            rbtnArea.TabStop = true;
            rbtnArea.Text = "Area";
            rbtnArea.UseVisualStyleBackColor = true;
            // 
            // rbtnVolume
            // 
            rbtnVolume.AutoSize = true;
            rbtnVolume.Location = new Point(8, 157);
            rbtnVolume.Name = "rbtnVolume";
            rbtnVolume.Size = new Size(65, 19);
            rbtnVolume.TabIndex = 9;
            rbtnVolume.TabStop = true;
            rbtnVolume.Text = "Volume";
            rbtnVolume.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(158, 82);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(lblResultado);
            Controls.Add(rbtnVolume);
            Controls.Add(rbtnArea);
            Controls.Add(rbtnPerimetro);
            Controls.Add(rbtnDiametro);
            Controls.Add(txtRaio);
            Controls.Add(btnCalcular);
            Name = "Form3";
            Text = "Area";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtRaio;
        private RadioButton rbtnDiametro;
        private RadioButton rbtnPerimetro;
        private RadioButton rbtnArea;
        private RadioButton rbtnVolume;
        private Label lblResultado;
    }
}