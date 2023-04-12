using System;
using System.Linq;
using System.Reflection.Metadata;

using var db = new BloggingContext();

// Note: This sample requires the database to be created before running.
Console.WriteLine($"Database path: {db.DbPath}.");

// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Contact { 
    Name = "Joao Pereira"
    });
db.SaveChanges();

// Read
Console.WriteLine("Querying for a blog");
var contact = db.Contacts
    .OrderBy(b => b.Name)
    .First();

// Update
Console.WriteLine("Updating the blog and adding a post");
contact.Name = "Johny Perao";
contact.PhoneNumber = "910481257";
db.SaveChanges();

// Delete
Console.WriteLine("Delete the blog");
db.Remove(contact);
db.SaveChanges();