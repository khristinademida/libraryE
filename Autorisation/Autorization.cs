using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Threading;
using Console = System.Console;

namespace Autorisation
{
    public partial class Autorization : Form
    {
  
        Show f2 = new Show();
        //private object button4;

        public Autorization()
        {
            InitializeComponent();
           

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Show f2 = new Show();
            f2.Show();
            f2.button4.Visible = false;
            f2.usersToolStripMenuItem.Visible = false;
            f2.textBox1.Visible = false;
            f2.button2.Visible = false;
            f2.booksToolStripMenuItem1.Visible = false;
            f2.authorsToolStripMenuItem1.Visible = false;
            f2.usersToolStripMenuItem1.Visible = false;
            f2.subscribesToolStripMenuItem.Visible = false;
           // f2.button3.Visible = false;
           // f2.textBox2.Visible = false;





        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
            if (textBox1.Text == "qqq" && textBox2.Text == "111")
            {
                this.Hide();
                Show f2 = new Show();
                f2.Show();
                
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Invalid login or password");
            }
        }
            
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}


