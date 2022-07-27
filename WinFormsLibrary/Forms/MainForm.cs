
using WinFormsLibrary.Models;

namespace WinFormsLibrary.Forms
{
   public partial class MainForm : Form
   {
      Library library;

      public MainForm()
      {
         InitializeComponent();
         library = new Library();
         library.FillWithTestData(100);
      }

   
      private void clearButton_Click(object sender, EventArgs e)
      {
         titleBox.Text = "";
         authorBox.Text = "";
         yearBox.Text = "";
         idBox.Text = "";

      }

      private void findButton_Click(object sender, EventArgs e)
      {
         if (!int.TryParse(idBox.Text, out int id))
            id = 0;
         if (!int.TryParse(yearBox.Text, out int year))
            year = 0;

         Book wanted = new Book
         {
            Title = titleBox.Text.Trim().ToLower(),
            Author = authorBox.Text.Trim().ToLower(), 
            Id = id, Year = year
         };
        
         var books = library.Find(wanted);
         booksGridView.DataSource = books;   
         //bookBindingSource.DataSource = books;
      }


      private void newToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Book book = new Book();
         var bookForm = new BookForm(book);
         if (bookForm.ShowDialog() == DialogResult.OK)
         {
            library.AddBook(book);
         }        
      }


      private void editToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Знаходимо вибрану книгу в результатах пошуку
         var book = bookBindingSource.Current as Book;
         if (book == null)
            return;
      
         var bookForm = new BookForm(book);
         if (bookForm.ShowDialog() == DialogResult.OK)
         {
            // в моделі за Id знаходимо книгу що редагується
            Book bookToChange = library.GetBookById(book.Id);

            // копіюємо поля
            bookToChange.Title = book.Title;
            bookToChange.Author = book.Author;
            bookToChange.Year = book.Year;

            // оновлюємо результати пошуку
            findButton_Click(null, null);
         }

      }

      private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }
   }
}
