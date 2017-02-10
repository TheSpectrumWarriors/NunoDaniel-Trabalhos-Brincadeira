namespace testesMALOKOOSSS
{
    partial class Form1
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
            this.textBoxTeste = new System.Windows.Forms.TextBox();
            this.buttonSomar = new System.Windows.Forms.Button();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSoma = new System.Windows.Forms.Panel();
            this.textBoxListaNomes = new System.Windows.Forms.TextBox();
            this.textBoxNomes = new System.Windows.Forms.TextBox();
            this.buttonAdicionarNomes = new System.Windows.Forms.Button();
            this.panelSoma.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTeste
            // 
            this.textBoxTeste.Location = new System.Drawing.Point(12, 68);
            this.textBoxTeste.Multiline = true;
            this.textBoxTeste.Name = "textBoxTeste";
            this.textBoxTeste.ReadOnly = true;
            this.textBoxTeste.Size = new System.Drawing.Size(89, 27);
            this.textBoxTeste.TabIndex = 0;
            this.textBoxTeste.TabStop = false;
            // 
            // buttonSomar
            // 
            this.buttonSomar.Location = new System.Drawing.Point(12, 38);
            this.buttonSomar.Name = "buttonSomar";
            this.buttonSomar.Size = new System.Drawing.Size(89, 24);
            this.buttonSomar.TabIndex = 1;
            this.buttonSomar.Text = "Somar";
            this.buttonSomar.UseVisualStyleBackColor = true;
            this.buttonSomar.Click += new System.EventHandler(this.buttonTeste_Click);
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(32, 20);
            this.textBoxNumber1.TabIndex = 2;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(69, 12);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(32, 20);
            this.textBoxNumber2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // panelSoma
            // 
            this.panelSoma.Controls.Add(this.label1);
            this.panelSoma.Controls.Add(this.textBoxNumber2);
            this.panelSoma.Controls.Add(this.textBoxNumber1);
            this.panelSoma.Controls.Add(this.buttonSomar);
            this.panelSoma.Controls.Add(this.textBoxTeste);
            this.panelSoma.Location = new System.Drawing.Point(0, 0);
            this.panelSoma.Name = "panelSoma";
            this.panelSoma.Size = new System.Drawing.Size(113, 106);
            this.panelSoma.TabIndex = 6;
            // 
            // textBoxListaNomes
            // 
            this.textBoxListaNomes.Location = new System.Drawing.Point(128, 42);
            this.textBoxListaNomes.Multiline = true;
            this.textBoxListaNomes.Name = "textBoxListaNomes";
            this.textBoxListaNomes.Size = new System.Drawing.Size(119, 201);
            this.textBoxListaNomes.TabIndex = 7;
            // 
            // textBoxNomes
            // 
            this.textBoxNomes.Location = new System.Drawing.Point(128, 12);
            this.textBoxNomes.Name = "textBoxNomes";
            this.textBoxNomes.Size = new System.Drawing.Size(79, 20);
            this.textBoxNomes.TabIndex = 8;
            // 
            // buttonAdicionarNomes
            // 
            this.buttonAdicionarNomes.Location = new System.Drawing.Point(213, 10);
            this.buttonAdicionarNomes.Name = "buttonAdicionarNomes";
            this.buttonAdicionarNomes.Size = new System.Drawing.Size(34, 23);
            this.buttonAdicionarNomes.TabIndex = 9;
            this.buttonAdicionarNomes.Text = "Add";
            this.buttonAdicionarNomes.UseVisualStyleBackColor = true;
            this.buttonAdicionarNomes.Click += new System.EventHandler(this.buttonAdicionarNomes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 308);
            this.Controls.Add(this.buttonAdicionarNomes);
            this.Controls.Add(this.textBoxNomes);
            this.Controls.Add(this.textBoxListaNomes);
            this.Controls.Add(this.panelSoma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSoma.ResumeLayout(false);
            this.panelSoma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeste;
        private System.Windows.Forms.Button buttonSomar;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSoma;
        private System.Windows.Forms.TextBox textBoxListaNomes;
        private System.Windows.Forms.TextBox textBoxNomes;
        private System.Windows.Forms.Button buttonAdicionarNomes;
    }
}

