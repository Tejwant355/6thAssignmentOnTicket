using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6thAssignmentOnTicket.Biz
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Emailsss { get; set; }
        public int TicketID { get; set; }
        public int SeatID { get; set; }
        public Ticket Ticket { get; set; }
        public Seat Seat { get; set; }
    }
}
