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
    public partial class Kuvat : Form
    {
        public Kuvat()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jatka_Click(object sender, EventArgs e)
        {
            {
                {
                    // Assuming you have a collection of checkboxes, replace it with your actual checkboxes
                    System.Windows.Forms.CheckBox[] checkboxes = { CheckBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9 };

                    // Additional checkboxes to check for the specific condition
                    System.Windows.Forms.CheckBox[] specificCheckboxes = { CheckBox1, checkBox5, checkBox7, checkBox9 };

                    // Check if any checkbox other than CheckBox1, checkBox5, checkBox7, and checkBox9 is checked
                    for (int i = 0; i < checkboxes.Length; i++)
                    {
                        if (checkboxes[i].Checked && !specificCheckboxes.Contains(checkboxes[i]))
                        {
                            MessageBox.Show("Yritä uudelleen.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Exit the method if any other checkbox is checked
                        }
                    }

                    // If CheckBox1, checkBox5, checkBox7, and checkBox9 are all checked, proceed
                    if (specificCheckboxes.All(checkbox => checkbox.Checked))
                    {
                        Etusivu etusivuForm = new Etusivu();
                        etusivuForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
    

