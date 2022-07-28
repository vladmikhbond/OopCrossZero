

using System.IO;
using System.Text.Json;

namespace WinFormsLibrary.Models
{
   public class Library
   {
      List<Book> books = new List<Book>();

      // Пошук за назвою, автором, роком видання, інв.номером
      //
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

      // Додає книгу до списку книг. Ставить інв.номер.
      //
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

      // Наповнює список книг тестовими даними.
      //
      public void FillWithTestData(int n)
      {
         books.Clear();
         for (int i = 0; i < n; i++)
         {
            AddBook(new Book { Title = "Harry Potter", Author = "Joanne Rowling", Year = 1997 });
            AddBook(new Book { Title = "The Lord of the Rings", Author = "John Tolkien", Year = 1954 });
         }
      }

      // Знаходить книгу по унікальному номеру
      //
      public Book GetBookById(int id)
      {
         return books.SingleOrDefault(b => b.Id == id);
      }

      const string TEXT_FILE_DEFAULT = "books.txt";
      const string JSON_FILE_DEFAULT = "books.txt";

      // Зберігає книги у текстовому файлі
      //      
      public void SaveText(string path = TEXT_FILE_DEFAULT)
      {
         using (var writer = new StreamWriter(path))
         {
            foreach (var b in books)
            {
               writer.WriteLine(b.Id);
               writer.WriteLine(b.Title);
               writer.WriteLine(b.Author);
               writer.WriteLine(b.Year);
            }
         }
      }

      // Завантажити книги з текстового файлу
      //
      public void LoadText(string path = TEXT_FILE_DEFAULT)
      {
         var lines = File.ReadAllLines(path); 
         books.Clear();
         for (var i = 0; i < lines.Length; i += 4)
         {
            var book = new Book() {
               Id = Convert.ToInt32(lines[i]),
               Title = lines[i + 1],
               Author = lines[i + 2],
               Year = Convert.ToInt32(lines[i + 3])
            };
            books.Add(book);  
         }                
      }

      public void SaveJson(string path = JSON_FILE_DEFAULT)
      {
         string jsonString = JsonSerializer.Serialize(books);
         File.WriteAllText(path, jsonString);
      }

      public void LoadJson(string path = JSON_FILE_DEFAULT)
      {
         string jsonString = File.ReadAllText(path);
         books = JsonSerializer.Deserialize<List<Book>>(jsonString);        
      }

   }
}
