using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_form
{
    public partial class MyListCustomUserControl : UserControl
    {
        double amt = 0;
        double burgamt = 40;
        double cakeamt = 150;
        double pizzaamt = 200;
        double pettisamt = 10;
        double pastryamt = 30;
        double paratheamt = 40;
        string tempstr;
        public MyListCustomUserControl()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Burger")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/burger1.jpg");
                costlabel.Text = "Rs 40 /-";

            }
            else if (comboBox1.Text == "Cake")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/cake.png");
                costlabel.Text = "Rs 150 /-";
            }
            else if (comboBox1.Text == "Pastry")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/pastry.jpg");
                costlabel.Text = "Rs 30 /-";
            }
            else if (comboBox1.Text == "Pizza")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/pizza.jpg");
                costlabel.Text = "Rs 200 /-";
            }
            else if (comboBox1.Text == "Pattise")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/pattis.jpg");
                costlabel.Text = "Rs 10 /-";
            }
            else if (comboBox1.Text == "Parathe")
            {
                pictureBox1.Image = new Bitmap("C:/Users/Rizwan/Pictures/parathe.jpg");
                costlabel.Text = "Rs 40 /-";
            }

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string str = comboBox1.Text;
            listBox1.Items.Add(str);
            if (comboBox1.Text == "Burger")
            {
                
                amt = amt + burgamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs "+tempstr + " /-";


            }
            else if (comboBox1.Text == "Cake")
            {
                amt = amt + cakeamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs " + tempstr + " /-";
            }
            else if (comboBox1.Text == "Pastry")
            {
                amt = amt + pastryamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs " + tempstr + " /-";
            }
            else if (comboBox1.Text == "Pizza")
            {
                amt = amt + pizzaamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs " + tempstr + " /-";
            }
            else if (comboBox1.Text == "Pattise")
            {
                amt = amt + pettisamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs " + tempstr + " /-";
            }
            else if (comboBox1.Text == "Parathe")
            {
                amt = amt + paratheamt;
                tempstr = amt.ToString();
                totalamt.Text = "Rs " + tempstr + " /-";
            }
        }

        private void execbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done! Now please write your complete Address");
            /*sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();*/
            
        }
    }
}
