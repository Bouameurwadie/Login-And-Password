using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_And_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "user" && textBox2.Text == "1234") // CHANGER LE USER ICI
            {
                
                    //Entre le Form :

                    //Form2 f = new Form2();
                    //f.Show();
                    //this.Hide();

                    //OR Messages Test :
                    MessageBox.Show("Welcome ");
               
                

            }
            else
            MessageBox.Show("Please check your username and password!!");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

                textBox1.Text = "Your userName";

            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {

                textBox2.Text = "Your Password";

            }
        }
    }
}
