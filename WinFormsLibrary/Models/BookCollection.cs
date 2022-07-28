
using System.Text.Json;

namespace WinFormsLibrary.Models
{
   public class BookCollection
   {
      List<Book> books = new List<Book>();
      public string FileName { set; get; }
      public bool IsDirty { set; get; }

      public BookCollection()
      {
         books = new List<Book>();
         FileName = "books.json";
         IsDirty = false;
         // TODO: get out
         FillWithTestData(100);
      }

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

      // Змінює книгу зі списку книг.
      //
      public bool ChangeBook(Book book)
      {
         for (int i = 0; i < books.Count; i++)
         {
            if (books[i].Id == book.Id)
            {
               books[i] = book;
               IsDirty = true;
               return true;
            }
         }
         return false;
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

      #region Save & Load

      public void SaveText(string path)
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

      public void LoadText(string path)
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

      // Зберігає книги у json-файлі
      //      
      public void SaveJson(string path)
      {
         string jsonString = JsonSerializer.Serialize(books);
         File.WriteAllText(path, jsonString);
         IsDirty = false;
         FileName = path;
      }

      // Завантажує книги з json-файлу
      //
      public void LoadJson(string path)
      {
         string jsonString = File.ReadAllText(path);
         books = JsonSerializer.Deserialize<List<Book>>(jsonString);
         IsDirty = false;
         FileName = path;
      }

      #endregion
   }
}
