using Microsoft.EntityFrameworkCore;
using PVA_Zápočet.Models;

namespace PVA_Zápočet.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions Options):base(Options) { }
		public DbSet<Credit> Credits { get; set; }
    }
}
