using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DomainModel
{
    public class Order
    {
        public string Name { get; set; }

        public string OrderNo { get; set; }

        public string Client { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DeadlineDate { get; set; }

        public DateTime DateSend { get; set; }

        public bool IsClosed { get; set; }

        public string Note { get; set; }

        public int? DrawingId { get; set; } 
    }
}
