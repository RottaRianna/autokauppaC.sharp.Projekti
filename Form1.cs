using System.Diagnostics.Eventing.Reader;

namespace PäättötyöViimeinenCSharp
{
    public partial class Luotunnus : Form
    {
        public Luotunnus()
        {
            InitializeComponent();
            Salasana.PlaceholderText = "Salasana";
            Nimi.PlaceholderText = "Käyttäjänimi";
        }

        private void Nimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salasana_TextChanged(object sender, EventArgs e)
        {

        }

        private void ihminen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jatka_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nimi.Text) && string.IsNullOrEmpty(Salasana.Text))
            {
                MessageBox.Show("Käyttäjänimi ja salasana eivät voi olla tyhjiä.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(ihminen.Checked))
            {
                MessageBox.Show("Varmista olevasi ihminen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Kuvat kuvatForm = new Kuvat();
                kuvatForm.ShowDialog();
                this.Close();
            }
        }
    }
}