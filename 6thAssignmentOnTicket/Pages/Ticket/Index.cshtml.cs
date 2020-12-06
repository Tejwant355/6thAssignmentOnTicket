using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _6thAssignmentOnTicket.Biz;
using _6thAssignmentOnTicket.Data;

namespace _6thAssignmentOnTicket.Pages.Ticket
{
    public class IndexModel : PageModel
    {
        private readonly _6thAssignmentOnTicket.Data.ApplicationDbContext _context;

        public IndexModel(_6thAssignmentOnTicket.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Biz.Ticket> Ticket { get;set; }

        public async Task OnGetAsync()
        {
            Ticket = await _context.Tickets.ToListAsync();
        }
    }
}
