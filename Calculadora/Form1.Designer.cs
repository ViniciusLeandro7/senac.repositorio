namespace Calculadora
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
            components = new System.ComponentModel.Container();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            label1 = new Label();
            btnSoma = new Button();
            label3 = new Label();
            lblRes = new Label();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            perimetorToolStripMenuItem = new ToolStripMenuItem();
            esferasToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            radioSoma = new RadioButton();
            radioSub = new RadioButton();
            radioMult = new RadioButton();
            radioDiv = new RadioButton();
            lblOperacao = new Label();
            btnCalcular = new Button();
            lblErro = new Label();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(56, 103);
            txtValor1.Margin = new Padding(3, 4, 3, 4);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(83, 27);
            txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(168, 103);
            txtValor2.Margin = new Padding(3, 4, 3, 4);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(83, 27);
            txtValor2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 30);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 2;
            label1.Text = "CALCULADORA";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(51, 171);
            btnSoma.Margin = new Padding(3, 4, 3, 4);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(54, 31);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 107);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 5;
            label3.Text = "=";
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Segoe UI", 12F);
            lblRes.Location = new Point(282, 103);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 28);
            lblRes.TabIndex = 6;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(125, 171);
            btnSub.Margin = new Padding(3, 4, 3, 4);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(45, 31);
            btnSub.TabIndex = 7;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(185, 171);
            btnMult.Margin = new Padding(3, 4, 3, 4);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(55, 31);
            btnMult.TabIndex = 8;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(259, 171);
            btnDiv.Margin = new Padding(3, 4, 3, 4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(49, 31);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(347, 30);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1, openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, perimetorToolStripMenuItem, esferasToolStripMenuItem });
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(128, 26);
            newToolStripMenuItem1.Text = "New";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(233, 26);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // perimetorToolStripMenuItem
            // 
            perimetorToolStripMenuItem.Name = "perimetorToolStripMenuItem";
            perimetorToolStripMenuItem.Size = new Size(233, 26);
            perimetorToolStripMenuItem.Text = "Quadrado/Retangulo";
            perimetorToolStripMenuItem.Click += perimetorToolStripMenuItem_Click;
            // 
            // esferasToolStripMenuItem
            // 
            esferasToolStripMenuItem.Name = "esferasToolStripMenuItem";
            esferasToolStripMenuItem.Size = new Size(233, 26);
            esferasToolStripMenuItem.Text = "Circunferencias";
            esferasToolStripMenuItem.Click += esferasToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // radioSoma
            // 
            radioSoma.AutoSize = true;
            radioSoma.Location = new Point(16, 221);
            radioSoma.Margin = new Padding(3, 4, 3, 4);
            radioSoma.Name = "radioSoma";
            radioSoma.Size = new Size(68, 24);
            radioSoma.TabIndex = 14;
            radioSoma.TabStop = true;
            radioSoma.Text = "Soma";
            radioSoma.UseVisualStyleBackColor = true;
            radioSoma.CheckedChanged += radioSoma_CheckedChanged;
            // 
            // radioSub
            // 
            radioSub.AutoSize = true;
            radioSub.Location = new Point(16, 255);
            radioSub.Margin = new Padding(3, 4, 3, 4);
            radioSub.Name = "radioSub";
            radioSub.Size = new Size(97, 24);
            radioSub.TabIndex = 15;
            radioSub.TabStop = true;
            radioSub.Text = "Subtração";
            radioSub.UseVisualStyleBackColor = true;
            radioSub.CheckedChanged += radioSub_CheckedChanged;
            // 
            // radioMult
            // 
            radioMult.AutoSize = true;
            radioMult.Location = new Point(16, 288);
            radioMult.Margin = new Padding(3, 4, 3, 4);
            radioMult.Name = "radioMult";
            radioMult.Size = new Size(120, 24);
            radioMult.TabIndex = 16;
            radioMult.TabStop = true;
            radioMult.Text = "Multiplicação";
            radioMult.UseVisualStyleBackColor = true;
            radioMult.CheckedChanged += radioMult_CheckedChanged;
            // 
            // radioDiv
            // 
            radioDiv.AutoSize = true;
            radioDiv.Location = new Point(16, 321);
            radioDiv.Margin = new Padding(3, 4, 3, 4);
            radioDiv.Name = "radioDiv";
            radioDiv.Size = new Size(79, 24);
            radioDiv.TabIndex = 17;
            radioDiv.TabStop = true;
            radioDiv.Text = "Divisão";
            radioDiv.UseVisualStyleBackColor = true;
            radioDiv.CheckedChanged += radioDiv_CheckedChanged;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(146, 107);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 18;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(125, 356);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 31);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(16, 412);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 20);
            lblErro.TabIndex = 20;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 455);
            Controls.Add(lblErro);
            Controls.Add(btnCalcular);
            Controls.Add(lblOperacao);
            Controls.Add(radioDiv);
            Controls.Add(radioMult);
            Controls.Add(radioSub);
            Controls.Add(radioSoma);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnSub);
            Controls.Add(lblRes);
            Controls.Add(label3);
            Controls.Add(btnSoma);
            Controls.Add(label1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label1;
        private Button btnSoma;
        private Label label3;
        private Label lblRes;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private RadioButton radioSoma;
        private RadioButton radioSub;
        private RadioButton radioMult;
        private RadioButton radioDiv;
        private Label lblOperacao;
        private Button btnCalcular;
        private Label lblErro;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem perimetorToolStripMenuItem;
        private ToolStripMenuItem esferasToolStripMenuItem;
    }
}
