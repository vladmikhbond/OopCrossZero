using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary.Models
{
   public class Library
   {
      List<Book> books = new List<Book>();

      public List<Book> Find (Book wanted)
      {
         var result = new List<Book>();
         foreach (var book in books)
         {
            if (wanted.Id != 0 && wanted.Id != book.Id)
               continue;
            if (wanted.Title != "" && book.Title.ToLower().IndexOf(wanted.Title) == -1)
               continue;
            if (wanted.Author != "" && book.Author.ToLower().IndexOf(wanted.Author) == -1)
               continue;
            if (wanted.Year != 0 && wanted.Year != book.Year)
               continue;
            result.Add(book);
         }
         return result; 
      }

      public void AddBook(Book book)
      {
         book.Id = UniqueId();
         books.Add(book);
      }

      int UniqueId()
      {
         if (books.Count == 0) 
            return 1;
         return books.Select(x => x.Id).Max() + 1;
      }

      public void FillWithTestData(int n)
      {
         books.Clear();
         for (int i = 0; i < n; i++)
         {
            AddBook(new Book { Title = "Harry Potter", Author = "Joanne Rowling", Year = 1997 });
            AddBook(new Book { Title = "The Lord of the Rings", Author = "John Tolkien", Year = 1954 });
         }
      }

      public Book GetBookById(int id)
      {
         return books.SingleOrDefault(b => b.Id == id);
      }
   }
}
