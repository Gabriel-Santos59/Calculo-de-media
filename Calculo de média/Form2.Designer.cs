namespace Calculo_de_média
{
    partial class FormCalculadora
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblMedia = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtMedia = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Segoe UI", 15F);
            lblNota1.Location = new Point(84, 34);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(72, 28);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Segoe UI", 15F);
            lblNota2.Location = new Point(294, 34);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(72, 28);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Segoe UI", 15F);
            lblNota3.Location = new Point(499, 34);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(72, 28);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota 3";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Font = new Font("Segoe UI", 15F);
            lblMedia.Location = new Point(89, 361);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(67, 28);
            lblMedia.TabIndex = 3;
            lblMedia.Text = "Média";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(52, 89);
            txtNota1.Multiline = true;
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(141, 31);
            txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(253, 89);
            txtNota2.Multiline = true;
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(141, 31);
            txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(465, 89);
            txtNota3.Multiline = true;
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(141, 31);
            txtNota3.TabIndex = 6;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(172, 361);
            txtMedia.Multiline = true;
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(128, 31);
            txtMedia.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(172, 203);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 36);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(420, 203);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(131, 36);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(581, 361);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(136, 43);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // FormCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtMedia);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblMedia);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "FormCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblMedia;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtMedia;
        private Button btnCalcular;
        private Button btnLimpar;
        private Button btnSair;
    }
}