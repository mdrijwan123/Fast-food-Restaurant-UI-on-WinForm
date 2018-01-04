using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Restaurant_form
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Rizwan\Documents\Visual Studio 2012\Projects\Restaurant_form\Restaurant_form\Database1.mdf;Integrated Security=True;");
            SqlDataAdapter sd = new SqlDataAdapter("select count(*) from LOGIN where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Welcome '" + textBox1.Text + "'!!");
                this.Hide();
                Form1 ss = new Form1();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Password Fail Dear '"+ textBox1.Text+"' Please check the password!!");
            }
        }
    }
}
