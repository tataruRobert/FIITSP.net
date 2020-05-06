using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Tataru_Robert_Rp.Models;

namespace Asp_Tataru_Robert_Rp.Data
{
    public class Asp_Tataru_Robert_RpContext : DbContext
    {
        public Asp_Tataru_Robert_RpContext (DbContextOptions<Asp_Tataru_Robert_RpContext> options)
            : base(options)
        {
        }
        // public Asp_Tataru_Robert_RpContext()
        // {
        //     Database.EnsureCreated();
        // }
        //
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(
        //         "Server=(localdb)\\mssqllocaldb;Database=Asp_Tataru_Robert_RpContext-3b397d0d-4109-45c4-96b2-f3711c9932a9;Trusted_Connection=True;MultipleActiveResultSets=true");
        // }

        public DbSet<Asp_Tataru_Robert_Rp.Models.Movie> Movie { get; set; }
    }
}
