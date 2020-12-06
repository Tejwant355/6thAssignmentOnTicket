using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _6thAssignmentOnTicket.Biz;
using _6thAssignmentOnTicket.Data;

namespace _6thAssignmentOnTicket.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly _6thAssignmentOnTicket.Data.ApplicationDbContext _context;

        public CreateModel(_6thAssignmentOnTicket.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SeatID"] = new SelectList(_context.Seats, "ID", "TotalSeats");
        ViewData["TicketID"] = new SelectList(_context.Tickets, "ID", "TicketNo");
            return Page();
        }

        [BindProperty]
        public Biz.Customer Customer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
