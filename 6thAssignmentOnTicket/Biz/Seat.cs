using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6thAssignmentOnTicket.Biz
{
    public class Seat
    {
        public int ID { get; set; }
        public string TotalSeats { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
