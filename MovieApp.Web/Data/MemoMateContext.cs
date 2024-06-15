using Microsoft.EntityFrameworkCore;
using MemoMate.Web.Models;

namespace MemoMate.Data
{
	public class MemoMateContext : DbContext
	{
		public MemoMateContext(DbContextOptions<MemoMateContext> options)
			: base(options)
		{
		}

		public DbSet<Note> Notes { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Note>()
				.HasOne(n => n.Creator)         // Note has 1 Creator
				.WithMany(u => u.Notes)         // Note has many 
				.HasForeignKey(n => n.CreatorId);  // Specifies the foreign key property

			modelBuilder.Entity<User>()
	            .HasMany(u => u.Notes)          // Bir User'ın birden çok Note'u olabilir
				.WithOne(n => n.Creator)        // Bir Note'un yalnızca bir Creator'u olabilir
				.HasForeignKey(n => n.CreatorId);  // ForeignKey olarak CreatorId kullanır


			base.OnModelCreating(modelBuilder);
		}

	}
}