using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    [Table(Name = "PublishingHouse")]
    class PublishingHouseC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_PublishingHouse { get; set; }
        [Column(Name = "PublishingHouseName")]
        public string PublishingHouseName { get; set; }
        [Column(Name = "City")]
        public string City { get; set; }
        [Column(Name = "Country")]
        public string Country { get; set; }
    }
}
