using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    [Table(Name = "Reviews")]
    class ReviewsC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Reviews { get; set; }
        [Column(Name = "Review")]
        public string Review { get; set; }
       
        [Column(Name = "AuthorID")]
        public int AuthorID { get; set; }
        [Column(Name = "BookID")]
        public int BookID { get; set; }
    }
}
