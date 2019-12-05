using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Autorisation
{
    public partial class AddReviews : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        DataContext db = new DataContext(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        public AddReviews()
        {

            InitializeComponent();
            var g = from s in db.GetTable<AuthorsC>() select s;
            foreach (var item in g)
            {
                listBox1.Items.Add(item.AuthorLastName + " " + item.AuthorFirstName + "," + item.id_Authors);
            }

            var ga = from s in db.GetTable<BooksC>() select s;
            foreach (var item in ga)
            {
                listBox2.Items.Add(item.BookName + "," + item.id_Books);
            }
        }
        int bookIDAutor;





        private void AddReviews_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("InsertReviews ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Review", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@BookID", SqlDbType.Int).Value = textBox2.Text.Trim();
                cmd.Parameters.AddWithValue("@AuthorID", SqlDbType.Int).Value = textBox3.Text.Trim();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Add");
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
                SqlCommand cmd = new SqlCommand("UpdateReviews ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Review", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@BookID", SqlDbType.Int).Value = textBox2.Text.Trim();
                cmd.Parameters.AddWithValue("@AuthorID", SqlDbType.Int).Value = textBox3.Text.Trim();
                cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = textBox4.Text.Trim();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
    }
}
    
    
