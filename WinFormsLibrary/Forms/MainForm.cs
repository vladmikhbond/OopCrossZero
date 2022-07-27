using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        
         var res = library.Find(wanted);
         bookBindingSource.DataSource = res;
      }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void editToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var book = bookBindingSource.Current as Book;
         if (book == null)
            return;
      
         var bookForm = new BookForm(book);
         if (bookForm.ShowDialog() == DialogResult.OK)
         {
            Book bookToChange = library.GetBookById(book.Id);
            bookToChange.Title = book.Title;
            bookToChange.Author = book.Author;
            bookToChange.Year = book.Year;
            findButton_Click(null, null);
         }

      }
   }
}
