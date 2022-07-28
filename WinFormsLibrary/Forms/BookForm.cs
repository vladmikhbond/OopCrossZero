
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

      private void titleBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         bool isValid = !string.IsNullOrEmpty((sender as TextBox).Text);
         if (isValid)
         {
            titleStar.Visible = false;
         } 
         else
         {
            e.Cancel = true;
            titleStar.Visible = true;
         } 
      }

      private void yearBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         bool isValid = int.TryParse((sender as TextBox).Text, out int year);
         isValid &= 0 < year && year < 3000;
         if (isValid)
         {
            yearStar.Visible = false;
         }
         else
         {
            e.Cancel = true;
            yearStar.Visible = true;
         }
      }

      private void yearStar_Click(object sender, EventArgs e)
      {

      }
   }
}
