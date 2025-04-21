namespace Calculadora
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
            radioPer = new RadioButton();
            radioArea = new RadioButton();
            radioVol = new RadioButton();
            btnCalcular = new Button();
            txtLado1 = new TextBox();
            lblRes = new Label();
            txtLado2 = new TextBox();
            label2 = new Label();
            lblErro = new Label();
            radioQuad = new RadioButton();
            radioRet = new RadioButton();
            groupBox1 = new GroupBox();
            txtLado3 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            quadradoRetânguloToolStripMenuItem = new ToolStripMenuItem();
            esferaToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // radioPer
            // 
            radioPer.AutoSize = true;
            radioPer.Location = new Point(38, 133);
            radioPer.Name = "radioPer";
            radioPer.Size = new Size(77, 19);
            radioPer.TabIndex = 0;
            radioPer.TabStop = true;
            radioPer.Text = "Perímetro";
            radioPer.UseVisualStyleBackColor = true;
            // 
            // radioArea
            // 
            radioArea.AutoSize = true;
            radioArea.Location = new Point(135, 133);
            radioArea.Name = "radioArea";
            radioArea.Size = new Size(49, 19);
            radioArea.TabIndex = 1;
            radioArea.TabStop = true;
            radioArea.Text = "Área";
            radioArea.UseVisualStyleBackColor = true;
            // 
            // radioVol
            // 
            radioVol.AutoSize = true;
            radioVol.Location = new Point(198, 133);
            radioVol.Name = "radioVol";
            radioVol.Size = new Size(65, 19);
            radioVol.TabIndex = 2;
            radioVol.TabStop = true;
            radioVol.Text = "Volume";
            radioVol.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(52, 170);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(63, 23);
            txtLado1.TabIndex = 4;
            txtLado1.Text = "0";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(24, 228);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 21);
            lblRes.TabIndex = 5;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(121, 170);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(63, 23);
            txtLado2.TabIndex = 7;
            txtLado2.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 81);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(12, 250);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 13;
            // 
            // radioQuad
            // 
            radioQuad.AutoSize = true;
            radioQuad.Checked = true;
            radioQuad.Location = new Point(11, 22);
            radioQuad.Name = "radioQuad";
            radioQuad.Size = new Size(78, 19);
            radioQuad.TabIndex = 14;
            radioQuad.TabStop = true;
            radioQuad.Text = "Quadrado";
            radioQuad.UseVisualStyleBackColor = true;
            radioQuad.CheckedChanged += radioQuad_CheckedChanged;
            // 
            // radioRet
            // 
            radioRet.AutoSize = true;
            radioRet.Location = new Point(170, 22);
            radioRet.Name = "radioRet";
            radioRet.Size = new Size(79, 19);
            radioRet.TabIndex = 15;
            radioRet.Text = "Retângulo";
            radioRet.UseVisualStyleBackColor = true;
            radioRet.CheckedChanged += radioRet_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioQuad);
            groupBox1.Controls.Add(radioRet);
            groupBox1.Location = new Point(24, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 50);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(190, 170);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(63, 23);
            txtLado3.TabIndex = 17;
            txtLado3.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(304, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, quadradoRetânguloToolStripMenuItem, esferaToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(186, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // quadradoRetânguloToolStripMenuItem
            // 
            quadradoRetânguloToolStripMenuItem.Name = "quadradoRetânguloToolStripMenuItem";
            quadradoRetânguloToolStripMenuItem.Size = new Size(186, 22);
            quadradoRetânguloToolStripMenuItem.Text = "Quadrado/Retângulo";
            quadradoRetânguloToolStripMenuItem.Click += quadradoRetânguloToolStripMenuItem_Click;
            // 
            // esferaToolStripMenuItem
            // 
            esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
            esferaToolStripMenuItem.Size = new Size(186, 22);
            esferaToolStripMenuItem.Text = "Esfera";
            esferaToolStripMenuItem.Click += esferaToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 27);
            label1.Name = "label1";
            label1.Size = new Size(211, 21);
            label1.TabIndex = 19;
            label1.Text = "QUADRADO / RETÂNGULO";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 341);
            Controls.Add(label1);
            Controls.Add(txtLado3);
            Controls.Add(groupBox1);
            Controls.Add(lblErro);
            Controls.Add(label2);
            Controls.Add(txtLado2);
            Controls.Add(lblRes);
            Controls.Add(txtLado1);
            Controls.Add(btnCalcular);
            Controls.Add(radioVol);
            Controls.Add(radioArea);
            Controls.Add(radioPer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioPer;
        private RadioButton radioArea;
        private RadioButton radioVol;
        private Button btnCalcular;
        private TextBox txtLado1;
        private Label lblRes;
        private TextBox txtLado2;
        private Label label2;
        private Label lblErro;
        private RadioButton radioQuad;
        private RadioButton radioRet;
        private GroupBox groupBox1;
        private TextBox txtLado3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem quadradoRetânguloToolStripMenuItem;
        private ToolStripMenuItem esferaToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label1;
    }
}