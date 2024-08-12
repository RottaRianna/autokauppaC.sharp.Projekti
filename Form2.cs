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
    public partial class Form2 : Form
    {
        public class Item
        {
            public string? Value { get; set; }
            public string? Text { get; set; }
        }
        public Form2()
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;


            List<Item> items1 = new List<Item>();
            items1.Add(new Item() { Text = "Vuosimalli", Value = "ValueText1" });
            items1.Add(new Item() { Text = "1970", Value = "ValueText2" });
            items1.Add(new Item() { Text = "1980", Value = "ValueText3" });
            items1.Add(new Item() { Text = "1990", Value = "ValueText4" });
            items1.Add(new Item() { Text = "2000", Value = "ValueText5" });
            items1.Add(new Item() { Text = "2010", Value = "ValueText6" });
            items1.Add(new Item() { Text = "2020", Value = "ValueText7" });


            // Add items to ComboBox2
            List<Item> items2 = new List<Item>();
            items2.Add(new Item() { Text = "Merkki", Value = "ValueText1" });
            items2.Add(new Item() { Text = "BMW", Value = "ValueText3" });
            items2.Add(new Item() { Text = "MAZDA", Value = "ValueText7" });
            items2.Add(new Item() { Text = "MERCEDES-BENZ", Value = "ValueText8" });
            items2.Add(new Item() { Text = "VOLGSWAGEN", Value = "ValueText14" });

        }

        private void InitializeComponent()
        {

        }
    }
}

   
