using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhatTheHecksForDinner.Models;

namespace WhatTheHecksForDinner.Data {
    public class WhatTheHecksForDinnerContext : DbContext
    {
        public WhatTheHecksForDinnerContext (DbContextOptions<WhatTheHecksForDinnerContext> options)
            : base(options)
        {
        }

        public DbSet<User>? User { get; set; }
    }
}
