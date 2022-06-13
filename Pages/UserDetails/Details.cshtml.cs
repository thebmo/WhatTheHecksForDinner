using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WhatTheHecksForDinner.Data;
using WhatTheHecksForDinner.Models;

namespace WhatTheHecksForDinner.Pages.UserDetails
{
    public class DetailsModel : PageModel
    {
        private readonly WhatTheHecksForDinnerContext _context;

        public DetailsModel(WhatTheHecksForDinnerContext context)
        {
            _context = context;
        }

      public UserDetail UserDetail { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || _context.UserDetails == null)
            {
                return NotFound();
            }

            var userDetail = await _context.UserDetails.FirstOrDefaultAsync(m => m.ID == id);
            if (userDetail == null)
            {
                return NotFound();
            }
            else 
            {
                UserDetail = userDetail;
            }
            return Page();
        }
    }
}
