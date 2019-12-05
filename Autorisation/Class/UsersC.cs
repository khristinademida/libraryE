using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    [Table(Name = "Users")]
    class UsersC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Users { get; set; }
        [Column(Name = "UserPasswordID")]
        public int UserPasswordID { get; set; }
        [Column(Name = "FirstName")]
        public string FirstName { get; set; }
        [Column(Name = "LastName")]
        public string LastName { get; set; }
    }
}
