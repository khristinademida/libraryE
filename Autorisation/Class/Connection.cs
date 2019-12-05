using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autorisation
{
    class Connection
    {
        string MyString;

        public void conection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FHN81NRV;Initial Catalog=Libr1;Integrated Security=True");
            connection.Open();

            MessageBox.Show("Connected");
           
        }

       

    }
}
