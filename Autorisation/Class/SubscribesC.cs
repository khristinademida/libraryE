using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Autorisation
{
    [Table(Name = "Subscribes")]
    class SubscribesC
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int id_Subscribes { get; set; }

        [Column(Name = "SubscriberID")]
        public int SubscriberID { get; set; }

        [Column(Name = "BookID")]
        public int BookID { get; set; }


        [Column(Name = "SubscribeStatus")]
        public string SubscribeStatus { get; set; }
        [Column(Name = "SubscribeDate")]
        public DateTime SubscribeDate { get; set; }

    }
}
