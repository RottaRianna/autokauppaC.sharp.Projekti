
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace PäättötyöViimeinenCSharp
    {
    public partial class Etusivu : Form
    {

        private void Etsi_Click(object sender, EventArgs e)
        {
            selectedBrand = comboBox2.Text;

            // Check if both the year and brand are selected
            if (!string.IsNullOrEmpty(selectedBrand))
            {
                // Check if the selected brand is "AUDI"
                if (selectedBrand.Equals("AUDI", StringComparison.OrdinalIgnoreCase))
                {
                    // Create an instance of the Audi form
                    Audi Audi = new Audi();

                    // Show the Audi form
                    Audi.Show();

                }
                else if (selectedBrand.Equals("BMW", StringComparison.OrdinalIgnoreCase))
                {

                    BMW BMW = new BMW();

                    BMW.Show();
                }
                else if (selectedBrand.Equals("MERCEDES-BENZ", StringComparison.OrdinalIgnoreCase))
                {

                    Mercedes Mercedes = new Mercedes();

                    Mercedes.Show();
                }
                else if (selectedBrand.Equals("MAZDA", StringComparison.OrdinalIgnoreCase))
                {
                    MAZDA Mazda = new MAZDA();

                    Mazda.Show();
                }
            }
            else
            {
                // Handle the case where year or brand is not selected
                MessageBox.Show("Please select brand before searching.");
            }
        }

        public class Item
        {
            public string? Value { get; set; }
            public string? Text { get; set; }
        }
        public Etusivu()
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;

            /* vuosimalli.Items.Add("1970");
             vuosimalli.Items.Add("1980");
             vuosimalli.Items.Add("1990");
             vuosimalli.Items.Add("2000");
             vuosimalli.Items.Add("2010");
             vuosimalli.Items.Add("2020");

             Merkki.Items.Add("AUDI");
             Merkki.Items.Add("BMW");
             Merkki.Items.Add("FORD");
             Merkki.Items.Add("LEXUS");
             Merkki.Items.Add("LADA");
             Merkki.Items.Add("MAZDA");
             Merkki.Items.Add("MERCEDES-BENZ");
             Merkki.Items.Add("NISSAN");
             Merkki.Items.Add("PORCHE");
             Merkki.Items.Add("SKODA");
             Merkki.Items.Add("TOYOTA");
             Merkki.Items.Add("VOLVO");
             Merkki.Items.Add("VOLGSWAGEN"); */

            InitializeComponent();


            // Add items to ComboBox2
            List<Item> items2 = new List<Item>();
            items2.Add(new Item() { Text = "Merkki", Value = "ValueText1" });
            items2.Add(new Item() { Text = "AUDI", Value = "ValueText2" });
            items2.Add(new Item() { Text = "BMW", Value = "ValueText3" });
            items2.Add(new Item() { Text = "MAZDA", Value = "ValueText7" });
            items2.Add(new Item() { Text = "MERCEDES-BENZ", Value = "ValueText8" });
            comboBox2.DataSource = items2;
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
        }
        private string selectedBrand = "";
        private void vuosimalli_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Merkki_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

