using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Odbc;
using System.Data.SqlClient;


namespace Autorisation
{
    public partial class AddBooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        DataContext db = new DataContext(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");

        public AddBooks()
        {

            InitializeComponent();
            var g = from s in db.GetTable<AuthorsC>() select s;
            foreach (var item in g)
            {
                checkedListBox.Items.Add(item.AuthorLastName + " " + item.AuthorFirstName + "," + item.id_Authors);
            }
        }


        int bookIDAutor;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("InsertBooks ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookName", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@PublishYear", SqlDbType.Int).Value = textBox2.Text.Trim();
                cmd.Parameters.AddWithValue("@Genre", SqlDbType.VarChar).Value = textBox3.Text.Trim();
                cmd.Parameters.AddWithValue("@Languages", SqlDbType.VarChar).Value = textBox4.Text.Trim();
                cmd.Parameters.AddWithValue("@PublishingHouseID", SqlDbType.Int).Value = textBox6.Text.Trim();
                cmd.ExecuteNonQuery();
                SqlCommand commandGet = new SqlCommand(
                    "Select ID FROM Books where Genre = @Genre AND BookName = @BookName AND Languages = @Languages AND PublishYear = @PublishYear", con);
                commandGet.Parameters.AddWithValue("Genre", textBox3.Text);
                commandGet.Parameters.AddWithValue("BookName", textBox1.Text);
                commandGet.Parameters.AddWithValue("Languages", textBox4.Text);
                commandGet.Parameters.AddWithValue("PublishYear", Convert.ToInt32(textBox2.Text));
                SqlDataReader dr = commandGet.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    bookIDAutor = Convert.ToInt32(dr["ID"]);
                }

                MessageBox.Show("Add");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            addAuthor();
        }


        private void addAuthor()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                
                for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("InsertBooksAuthors", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", SqlDbType.Int).Value = bookIDAutor;
                    var data = checkedListBox.CheckedItems[i];
                    var id = Convert.ToInt32(data.ToString().Split(',')[1]);
                    cmd.Parameters.AddWithValue("@AuthorID", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
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
            int id_Authors = 0;
            string l = checkedListBox.GetItemText(checkedListBox.SelectedItem);

            var gan = from s in db.GetTable<AuthorsC>() select s;
            foreach (var item in gan)
            {
                if (l == item.Name)
                {
                    id_Authors = item.id_Authors;
                }
            }
            MessageBox.Show(l);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActorSelect(ListBox s)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}

