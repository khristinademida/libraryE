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

namespace Autorisation
{
    public partial class AddUsers : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        int ContactId = 0;
        public AddUsers()
        {
            InitializeComponent();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("InsertUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserPasswordID", SqlDbType.Int).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = textBox3.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add User");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("UpdateUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserPasswordID", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = textBox3.Text.Trim();
            cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = textBox4.Text.Trim();
             cmd.ExecuteNonQuery();
            MessageBox.Show("Update User");
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
}
    }
}

