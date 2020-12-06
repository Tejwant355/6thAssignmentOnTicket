using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6thAssignmentOnTicket.Biz
{
    public class Ticket
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string TicketNo { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
