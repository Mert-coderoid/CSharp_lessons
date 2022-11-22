using System;
using Microsoft.EntityFrameworkCore;
using WebApi2.Entities;

namespace WebApi2.DBOperations
{
    public class BookStoreDBContext : DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}