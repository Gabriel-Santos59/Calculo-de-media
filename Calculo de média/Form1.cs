namespace Calculo_de_média
{
    public partial class FormTelaprincipal : Form
    {
        public FormTelaprincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            FormCalculadora formcalculadora = new FormCalculadora();

            formcalculadora.Show();
        }

    }
}
