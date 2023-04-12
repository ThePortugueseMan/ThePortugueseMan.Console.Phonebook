using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class BloggingContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }

    public string DbPath { get; }

    public BloggingContext()
    {
        DbPath = "UHLAHLAH;Initial Catalog=PhoneBook;Integrated Security=True;TrustServerCertificate = True;";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source={DbPath}");
}


public class Contact
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}