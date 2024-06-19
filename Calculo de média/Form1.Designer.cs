namespace Calculo_de_média
{
    partial class FormTelaprincipal
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
            btnCalculadora = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(286, 203);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(160, 51);
            btnCalculadora.TabIndex = 0;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(173, 97);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(403, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Clique abaixo para acessar o campo de notas";
            // 
            // FormTelaprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnCalculadora);
            Name = "FormTelaprincipal";
            Text = "Tela Inicial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculadora;
        private Label lblTitulo;
    }
}
