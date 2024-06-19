using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_média
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;

            n1 = double.Parse(txtNota1.Text);
            n2 = double.Parse(txtNota2.Text);
            n3 = double.Parse(txtNota3.Text);

            media = n1 + n2 + n3 / 3;

            txtMedia.Text = media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtMedia.Clear();

            txtNota1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
