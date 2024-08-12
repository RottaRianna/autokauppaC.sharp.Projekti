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
    public partial class MAZDA : Form
    {
        public MAZDA()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Etusivu previousForm = new Etusivu();

            // Hide the current form
            this.Hide();

            // Show the previous form
            previousForm.Show();
        }

        private void nappi1970_Click(object sender, EventArgs e)
        {
            // Hide groupBox1 when 1970 is selected
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void nappi1980_Click(object sender, EventArgs e)
        {
            // Show groupBox1 when 1980 is selected
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
    }
}