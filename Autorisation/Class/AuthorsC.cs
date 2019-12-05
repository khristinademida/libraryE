using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{

    [Table(Name = "Authors")]
    class AuthorsC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Authors { get; set; }
        [Column(Name = "AuthorFirstName")]
        public string AuthorFirstName { get; set; }
        [Column(Name = "AuthorLastName")]
        public string AuthorLastName { get; set; }
        public object Name { get; internal set; }
    }
}
