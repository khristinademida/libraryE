using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{

    [Table(Name = "Books")]
    class BooksC
    {

        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Books { get; set; }


        [Column(Name = "Genre")]
        public string Genre { get; set; }

        [Column(Name = "BookName")]
        public string BookName { get; set; }

        [Column(Name = "Languages")]
        public string Languages { get; set; }

        [Column(Name = "PublishYear")]
        public int PublishYear { get; set; }

        [Column(Name = "PublishingHouseID")]
        public int PublishingHouseID { get; set; }
    }
}
