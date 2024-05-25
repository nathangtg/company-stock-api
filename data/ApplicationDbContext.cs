using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace company_stock_api.data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<models.Stock> Stocks { get; set; } = null!;
        public DbSet<models.Comments> Comments { get; set; } = null!;
    }
}