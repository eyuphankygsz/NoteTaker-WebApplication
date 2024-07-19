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
		public DbSet<UserEntity> Users { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Rate> Rates { get; set; }
		public DbSet<Theme> Themes { get; set; }
		public DbSet<Like> Likes { get; set; }
		public DbSet<Friend> Friends { get; set; }
		public DbSet<Message> Messages { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Note>();

			modelBuilder.Entity<UserEntity>()
				.HasMany(u => u.Posts)
				.WithOne(p => p.UserEntity)
				.HasForeignKey(u => u.UserID);


			modelBuilder.Entity<Post>(post =>
			{
				post.HasOne(p => p.NoteEntity)
					.WithOne()
					.HasForeignKey<Post>(p => p.NoteID);

				post.HasOne(p => p.UserEntity)
					.WithMany(u => u.Posts)
					.HasForeignKey(p => p.UserID);

				post.HasOne(p => p.ThemeEntity)
					.WithMany()
					.HasForeignKey(p => p.ThemeID);

			});

			modelBuilder.Entity<Rate>(rate =>
			{
				rate.HasOne(p => p.PostEntity)
					.WithMany()
					.HasForeignKey(p => p.PostID);

				rate.HasOne(p => p.UserEntity)
					.WithMany()
					.HasForeignKey(p => p.UserID);
			});

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Like>(like =>
			{
				like.HasOne(l => l.UserEntity)
				.WithMany()
				.HasForeignKey(l => l.UserID);

				like.HasOne(l => l.PostEntiy)
				.WithMany()
				.HasForeignKey(l => l.PostID);
			});

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("YourConnectionStringHere",
					sqlServerOptions => sqlServerOptions.EnableRetryOnFailure());
			}
		}
	}
}