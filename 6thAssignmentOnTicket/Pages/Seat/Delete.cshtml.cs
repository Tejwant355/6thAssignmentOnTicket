using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _6thAssignmentOnTicket.Biz;
using _6thAssignmentOnTicket.Data;

namespace _6thAssignmentOnTicket.Pages.Seat
{
    public class DeleteModel : PageModel
    {
        private readonly _6thAssignmentOnTicket.Data.ApplicationDbContext _context;

        public DeleteModel(_6thAssignmentOnTicket.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Biz.Seat Seat { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seat = await _context.Seats.FirstOrDefaultAsync(m => m.ID == id);

            if (Seat == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seat = await _context.Seats.FindAsync(id);

            if (Seat != null)
            {
                _context.Seats.Remove(Seat);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
