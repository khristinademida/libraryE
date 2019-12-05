using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    [Table(Name = "Books_Authors")]
    class Books_Authors
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Books_Authors { get; set; }

        [Column(Name = "AuthorsID")]
        public int AuthorsID { get; set; }
        [Column(Name = "BooksID")]
        public int BooksID { get; set; }
    }
}
