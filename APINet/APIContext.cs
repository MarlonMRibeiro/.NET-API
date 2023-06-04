using APINet.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APINet
{
    public class APIContext : IdentityDbContext<Usuario, IdentityRole<Guid>, Guid>
    {
        public DbSet<Usuario> Usuario { get; set; }

        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }
    }
}
