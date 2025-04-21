namespace Calculadora
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
            txtRaio = new TextBox();
            radioPer = new RadioButton();
            radioDia = new RadioButton();
            radioArea = new RadioButton();
            radioVol = new RadioButton();
            label1 = new Label();
            btncalcular = new Button();
            label2 = new Label();
            lblRes = new Label();
            lblErro = new Label();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            quadradoRetânguloToolStripMenuItem = new ToolStripMenuItem();
            esferaToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(106, 172);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(78, 23);
            txtRaio.TabIndex = 0;
            // 
            // radioPer
            // 
            radioPer.AutoSize = true;
            radioPer.Checked = true;
            radioPer.Location = new Point(39, 69);
            radioPer.Name = "radioPer";
            radioPer.Size = new Size(77, 19);
            radioPer.TabIndex = 1;
            radioPer.TabStop = true;
            radioPer.Text = "Perimetro";
            radioPer.UseVisualStyleBackColor = true;
            radioPer.CheckedChanged += radioPer_CheckedChanged;
            // 
            // radioDia
            // 
            radioDia.AutoSize = true;
            radioDia.Location = new Point(182, 69);
            radioDia.Name = "radioDia";
            radioDia.Size = new Size(74, 19);
            radioDia.TabIndex = 2;
            radioDia.Text = "Diametro";
            radioDia.UseVisualStyleBackColor = true;
            radioDia.CheckedChanged += radioDia_CheckedChanged;
            // 
            // radioArea
            // 
            radioArea.AutoSize = true;
            radioArea.Location = new Point(39, 112);
            radioArea.Name = "radioArea";
            radioArea.Size = new Size(49, 19);
            radioArea.TabIndex = 3;
            radioArea.Text = "Area";
            radioArea.UseVisualStyleBackColor = true;
            radioArea.CheckedChanged += radioArea_CheckedChanged;
            // 
            // radioVol
            // 
            radioVol.AutoSize = true;
            radioVol.Location = new Point(182, 112);
            radioVol.Name = "radioVol";
            radioVol.Size = new Size(65, 19);
            radioVol.TabIndex = 4;
            radioVol.Text = "Volume";
            radioVol.UseVisualStyleBackColor = true;
            radioVol.CheckedChanged += radioVol_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 175);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Raio";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(109, 267);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 234);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 7;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRes.Location = new Point(23, 221);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 21);
            lblRes.TabIndex = 8;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(12, 317);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 15);
            lblErro.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(304, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem, saveToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(37, 20);
            newToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, quadradoRetânguloToolStripMenuItem, esferaToolStripMenuItem });
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(103, 22);
            newToolStripMenuItem1.Text = "New";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 34);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 11;
            label3.Text = "ESFERA";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 341);
            Controls.Add(label3);
            Controls.Add(lblErro);
            Controls.Add(lblRes);
            Controls.Add(label2);
            Controls.Add(btncalcular);
            Controls.Add(label1);
            Controls.Add(radioVol);
            Controls.Add(radioArea);
            Controls.Add(radioDia);
            Controls.Add(radioPer);
            Controls.Add(txtRaio);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private RadioButton radioPer;
        private RadioButton radioDia;
        private RadioButton radioArea;
        private RadioButton radioVol;
        private Label label1;
        private Button btncalcular;
        private Label label2;
        private Label lblRes;
        private Label lblErro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem quadradoRetânguloToolStripMenuItem;
        private ToolStripMenuItem esferaToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label3;
    }
}