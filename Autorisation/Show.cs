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
using System.Data.Odbc;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    public partial class Show : Form
    {
        // Autorization tab = new Autorization();
        DataContext db = new DataContext(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");

        public Show()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
        DataTable table = new DataTable();


        private void Show_Load(object sender, EventArgs e)
        {
            searchData("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //       SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S55942R\SEKHARSQL;Initial Catalog=Libr1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select  Books_Authors.BooksID, Books.BookName, Books_Authors.AuthorsID, Authors.AuthorFirstName, Authors.AuthorLastName  FROM  Books_Authors inner join Books
on  Books_Authors.BooksID = Books.ID
inner join Authors
on Books_Authors.AuthorsID = Authors.ID ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-S55942R\\SEKHARSQL;Initial Catalog=Libr1;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter(@"  Select  Authors.ID, Authors.AuthorFirstName, Authors.AuthorLastName, Books.BookName, PublishingHouse.PublishingHouseName FROM  Authors inner join Books 
            //            on   Authors.ID = Books.ID
            //inner join PublishingHouse 
            //            on   Authors.ID = PublishingHouse.ID", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void AddBooks_Click(object sender, EventArgs e)
        {



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }



        private void IID_TextChanged(object sender, EventArgs e)
        {

        }


        private void Add_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
            //var a = from s in db.GetTable<BooksC>() select s;
            //dataGridView1.DataSource = a;

            /*table.Rows.Add(IID.Text, IBookName.Text, IAuthorLastName.Text, IGenre.Text, ILanguageName.Text, IPublishYear.Text);
            dataGridView1.DataSource = table;*/
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }






        //vuvid tables
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM Books", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select  * FROM Authors", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void publishingHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM PublishingHouse", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM Users", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void submitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM Subscribes", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddBooks f2 = new AddBooks();
            f2.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM Reviews", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        //search

        public void searchData(string valueToFind)
        {
            string searchQuery = @"Select  Books.ID,  Books.BookName, Authors.AuthorFirstName,  Authors.AuthorLastName, Books.Genre, Books.Languages, Books.PublishYear, PublishingHouse.PublishingHouseName FROM  Books inner join Authors 
                 on Books.ID = Authors.ID
                 inner join PublishingHouse
                 on Books.PublishingHouseID = PublishingHouse.ID WHERE CONCAT(BookName,Genre, AuthorFirstName, AuthorLastName) LIKE '%" + valueToFind + "%'" ;
            SqlDataAdapter adapter = new SqlDataAdapter(searchQuery, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void textBox1Search_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1Search.Text);
        }

        //delete books
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)

                    connection.Open();
                SqlCommand cmd = new SqlCommand("DeleteBooks", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = textBox1.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete books");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUsers f2 = new AddUsers();
            f2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select  Users.ID,  Users.UserPasswordID, Users.FirstName,  Users.LastName, Reviews.BookId, Reviews.AuthorID, Subscribes.SubscribeStatus, Reviews.Review FROM  Users inner join Reviews 
                 on    Users.ID = Reviews.ID 
                 inner join Subscribes
                 on Users.ID = Subscribes.ID ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void authorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAuthors f2 = new AddAuthors();
            f2.Show();
        }


        private void ganreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReviews form = new AddReviews();
            form.Show();
        }

        private void subscribesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSubscribes form = new AddSubscribes();
            form.Show();
        }

        private void booksAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"   Select * FROM Books_Authors", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
