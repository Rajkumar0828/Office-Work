using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace mysqlefcore
{
  class Program
  {
    static void Main(string[] args)
    {
      //InsertData();
      //UpdateBook("978-0544003415", "Asha", 1234);
      DeleteBook("978-0544003415");
      PrintData();
    }

    private static void InsertData()
    {
      using(var context = new LibraryContext())
      {
        // Creates the database if not exists
        context.Database.EnsureCreated();

        // Adds a publisher
        var publisher = new Publisher
        {
          Name = "Mariner Books"
        };
        context.Publisher.Add(publisher);

        // Adds some books
        context.Book.Add(new Book
        {
          ISBN = "978-4003415",
          Title = "The Lord of the Rings",
          Author = "J.R.R. Tolkien",
          Language = "English",
          Pages = 1216,
          Publisher = publisher
        });
        context.Book.Add(new Book
        {
          ISBN = "978-05762",
          Title = "The Sealed Letter",
          Author = "Emma Donoghue",
          Language = "English",
          Pages = 416,
          Publisher = publisher
        });

        // Saves changes
        context.SaveChanges();
      }
    }

    private static void PrintData()
    {
      // Gets and prints all books in database
      using (var context = new LibraryContext())
      {
        var books = context.Book
          .Include(p => p.Publisher);
        foreach(var book in books)
        {
          var data = new StringBuilder();
          data.AppendLine($"ISBN: {book.ISBN}");
          data.AppendLine($"Title: {book.Title}");
          data.AppendLine($"Publisher: {book.Publisher.Name}");
          Console.WriteLine(data.ToString());
        }
      }
    }
    private static void UpdateBook(string isbn, string newTitle, int newPages)
  {
  using(var context = new LibraryContext())
  {
    // Retrieve the book by ISBN
    var book = context.Book.FirstOrDefault(b => b.ISBN == isbn);
    
    if(book != null)
    {
      // Update the properties
      book.Title = newTitle;
      book.Pages = newPages;
      
      // Save the changes
      context.SaveChanges();
    }
  }
}
private static void DeleteBook(string isbn)
{
  using(var context = new LibraryContext())
  {
    // Retrieve the book by ISBN
    var bookToDelete = context.Book.FirstOrDefault(b => b.ISBN == isbn);
    
    if(bookToDelete != null)
    {
      // Remove the book from the context
      context.Book.Remove(bookToDelete);
      
      // Save the changes to the database
      context.SaveChanges();
    }
  }
}
  }
}