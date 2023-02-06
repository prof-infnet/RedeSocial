using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedeSocial.API.Models;

namespace RedeSocial.API.Data
{
    public class RedeSocialAPIContext : DbContext
    {
        public RedeSocialAPIContext (DbContextOptions<RedeSocialAPIContext> options)
            : base(options)
        {
        }

        public DbSet<RedeSocial.API.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
