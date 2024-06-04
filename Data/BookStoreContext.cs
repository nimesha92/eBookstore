using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookStore.ViewModels;

namespace BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<DefaultUser>
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<BookStore.Models.Book> Book { get; set; } = default!;
        public DbSet<BookStore.Models.SeedData> SeedData { get; set; } = default!;
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<BookStore.ViewModels.UserRoleViewModel> UserRoleViewModel { get; set; } = default!;
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
