using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autorisation
{
    public partial class AddSubscribes : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        DataContext db = new DataContext(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");

        public object Me { get; private set; }

        public AddSubscribes()
        {
            InitializeComponent();
            var g = from s in db.GetTable<UsersC>() select s;
            foreach (var item in g)
            {
                listBox1.Items.Add(item.LastName + " " + item.FirstName + "," + item.id_Users);
            }

            var ga = from s in db.GetTable<BooksC>() select s;
            foreach (var item in ga)
            {
                listBox2.Items.Add(item.BookName + "," + item.id_Books);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("InsertSubscribes ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubscribeStatus", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.Add("@SubscribeDate", SqlDbType.Date);
                cmd.Parameters["@SubscribeDate"].Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = textBox3.Text.Trim();
                cmd.Parameters.AddWithValue("@BookID", SqlDbType.Int).Value = textBox4.Text.Trim();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Add");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void AddSubscribes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("UpdateSubscribes ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SubscribeStatus", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.Add("@SubscribeDate", SqlDbType.Date);
                cmd.Parameters["@SubscribeDate"].Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@SubscriberID", SqlDbType.Int).Value = textBox3.Text.Trim();
                cmd.Parameters.AddWithValue("@BookID", SqlDbType.Int).Value = textBox4.Text.Trim();
                cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = textBox2.Text.Trim();
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
