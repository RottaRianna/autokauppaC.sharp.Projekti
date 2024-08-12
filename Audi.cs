using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PäättötyöViimeinenCSharp
{
    public partial class Audi : Form
    {
        public Audi()
        {

            InitializeComponent();
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

        private void label4_Click(object sender, EventArgs e)
        {
            // Code for label4 click event
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Code for groupBox1 enter event
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Audi_Load(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}