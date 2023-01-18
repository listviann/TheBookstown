using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheBookstown.Domain.Entities;

namespace TheBookstown.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<UserCartItem> UserCartItems { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<PageTextField> PagesTextFields { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PageTextField>().HasData(new PageTextField()
            {
                Id = new Guid("0d00b1e0-16a9-45de-8cab-ad2725f0dd5c"),
                CodeWord = "Home",
                Name = "Books"
            });

            builder.Entity<PageTextField>().HasData(new PageTextField()
            {
                Id = new Guid ("ad27cb7d-7743-430e-8d90-d08f2a957d24"),
                CodeWord = "Authors",
                Name = "Authors"
            });

            builder.Entity<PageTextField>().HasData(new PageTextField()
            {
                Id = new Guid("88c027ca-a133-417d-a41a-c955b78a876a"),
                CodeWord = "Cart",
                Name = "Cart"
            });

            builder.Entity<PageTextField>().HasData(new PageTextField()
            {
                Id = new Guid("5c3d573c-e877-40a5-9d83-6b61f0399704"),
                CodeWord = "Orders",
                Name = "Orders history"
            });

            builder.Entity<PageTextField>().HasData(new PageTextField()
            {
                Id = new Guid("c1fc83e1-b1ab-49bf-8105-ca4b62f51a2c"),
                CodeWord = "Profile",
                Name = "Profile"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c0f6254-2cf1-4cbe-b97e-af81ca704cd2",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ab0d461e-6966-4e9d-80e5-17e426c9f048",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null!, "bookadmin"),
                SecurityStamp = String.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "2c0f6254-2cf1-4cbe-b97e-af81ca704cd2",
                UserId = "ab0d461e-6966-4e9d-80e5-17e426c9f048"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ad51c364-7e53-45d3-9ba5-ece42554338e",
                Name = "ordinary",
                NormalizedName = "ORDINARY"
            });

            builder.Entity<Author>().HasIndex(a => a.Name).IsUnique();
            builder.Entity<Genre>().HasIndex(g => g.Name).IsUnique();
            builder.Entity<IdentityUser>().HasIndex(u => u.UserName).IsUnique();
        }
    }
}
