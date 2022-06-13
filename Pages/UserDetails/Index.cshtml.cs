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
    public class IndexModel : PageModel
    {
        private readonly WhatTheHecksForDinnerContext _context;

        public IndexModel(WhatTheHecksForDinnerContext context)
        {
            _context = context;
        }

        public IList<UserDetail> UserDetails { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.UserDetails != null)
            {
                UserDetails = await _context.UserDetails.ToListAsync();
            }
        }
    }
}
