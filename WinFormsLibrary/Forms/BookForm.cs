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
   public partial class BookForm : Form
   {

      public BookForm(Book book)
      {
         InitializeComponent();
         bookBindingSource.DataSource = book;
         //if (book != null)
         //{
         //   titleBox.Text = book.Title;
         //   authorBox.Text = book.Author;
         //   yearBox.Text = book.Year.ToString();   
         //}
      }

      private void saveButton_Click(object sender, EventArgs e)
      {

      }
   }
}
