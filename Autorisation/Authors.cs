using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace Autorisation
{
    class Authors
    {
        //public static List<string> OutTeacher_Colums()
        //{
        //    List<string> count = new List<string>()
        //    {
        //        "ID",
        //        " PublishingHouseID ", "AuthorFirstName", "AuthorLastName"
        //    };
        //    return count;
        //}
        //public static void AddAuthors(string PublishingHouseID, string AuthorFirstName, string AuthorLastName)
        //{
        //    OdbcCommand MyCommand;
        //    MyCommand = Connect.Conn();
        //    MyCommand.CommandText = "INSERT INTO Authors(PublishingHouseID,  AuthorFirstName, AuthorLastName) VALUES('" + PublishingHouseID + "','" + AuthorFirstName + "','" + AuthorLastName + "')";
        //    MyCommand.ExecuteNonQuery();

        //}

        //internal static IEnumerable<string> OutAuthors_Colums()
        //{
        //    throw new NotImplementedException();
        //}

        //internal static OdbcDataReader OutAuthors()
        //{
        //    throw new NotImplementedException();
        //}

        //public static OdbcDataReader OutTeacher()
        //{
        //    OdbcCommand MyCommand;
        //    MyCommand = Connect.Conn();
        //    MyCommand.CommandText = "SELECT * FROM Authors";
        //    OdbcDataReader MyDataReader;
        //    MyDataReader = MyCommand.ExecuteReader();
        //    return MyDataReader;
        //}
        //public static void UpdateAuthors(string ID, string PublishingHouseID, string AuthorFirstName, string AuthorLastName)
        //{
        //    OdbcCommand MyCommand;
        //    MyCommand = Connect.Conn();
        //    MyCommand.CommandText = "UPDATE  Authors SET PublishingHouseID = '" + PublishingHouseID + "',AuthorFirstName  ='" + AuthorFirstName + "',AuthorLastName ='" + AuthorLastName + "' WHERE ID = " + ID;
        //    MyCommand.ExecuteNonQuery();

        //}
        //public static void DelAuthors(int ID)
        //{

        //    OdbcCommand MyCommand;
        //    MyCommand = Connect.Conn();
        //    MyCommand.CommandText = "DELETE FROM Authors where ID = " + ID;
        //    MyCommand.ExecuteNonQuery();


        //}
        //public static OdbcDataReader FindAuthors(string ID, string PublishingHouseID, string AuthorFirstName, string AuthorLastName)
        //{
        //    OdbcCommand MyCommand;
        //    MyCommand = Connect.Conn();

        //    string request;
        //    int and = 0;
        //    request = "SELECT * FROM Authors WHERE ";
        //    if (ID != "")
        //    {
        //        if (and == 1)
        //            request = request + " and ";
        //        request = request + " ID= " + ID;
        //        and = 1;
        //    }
        //    if (AuthorLastName != "")
        //    {
        //        if (and == 1)
        //            request = request + " and ";
        //        request = request + " AuthorLastName LIKE '%" + AuthorLastName + "%' ";
        //        and = 1;
        //    }
        //    if (AuthorFirstName != "")
        //    {
        //        if (and == 1)
        //            request = request + " and ";
        //        request = request + " AuthorFirstName LIKE '%" + AuthorFirstName + "%' ";
        //        and = 1;
        //    }
        //    if (PublishingHouseID != "")
        //    {
        //        if (and == 1)
        //            request = request + " and ";
        //        request = request + " PublishingHouseID LIKE '%" + PublishingHouseID + "%' ";
        //        and = 1;
        //    }
           

        //    MyCommand.CommandText = request;
        //    OdbcDataReader MyDataReader;
        //    MyDataReader = MyCommand.ExecuteReader();
        //    return MyDataReader;
        //}
    }
}

