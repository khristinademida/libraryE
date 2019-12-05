using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorisation
{
    public partial class AddAuthors : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        public AddAuthors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("InsertAuthors", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorFirstName", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@AuthorLastName", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void AddAuthors_Load(object sender, EventArgs e)
        {

        }
    }
}
