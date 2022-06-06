using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WhatTheHecksForDinner.Data;
using WhatTheHecksForDinner.Models;

namespace WhatTheHecksForDinner.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly WhatTheHecksForDinnerContext _context;

        public DetailsModel(WhatTheHecksForDinnerContext context)
        {
            _context = context;
        }

      public User User { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.User == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else 
            {
                User = user;
            }
            return Page();
        }
    }
}
