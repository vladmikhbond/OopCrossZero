
using WinFormsLibrary.Models;

namespace WinFormsLibrary.Forms
{
   public partial class BookForm : Form
   {

      public BookForm(Book book)
      {
         InitializeComponent();
         bookBindingSource.DataSource = book;
      }

   }
}
