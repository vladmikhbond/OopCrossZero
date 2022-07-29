

using WinFormsLibrary.Models;

namespace WinFormsLibrary.Forms
{
   public partial class MainForm : Form
   {
      BookCollection model;

      public MainForm()
      {
         InitializeComponent();
         model = new BookCollection();      
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
            Id = id,
            Year = year
         };

         var books = model.Find(wanted);
         bookBindingSource.DataSource = books;        
      }


      private void newToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Book book = new Book();
         var bookForm = new BookForm(book);
         if (bookForm.ShowDialog() == DialogResult.OK)
         {
            model.AddBook(book);
            // оновлюємо результати пошуку
            findButton_Click(null, null);
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
            model.ChangeBook(book);
            // оновлюємо результати пошуку
            findButton_Click(null, null);
         }

      }

      #region menus

      private void newToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         model = new BookCollection();
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            try
            {
               model.LoadJson(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Завантаження не відбулося \n" + ex.Message);
            }
         }
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         model.SaveJson(model.FileName);
      }

      private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (saveFileDialog1.ShowDialog() == DialogResult.OK)
         {
            model.SaveJson(saveFileDialog1.FileName);
         }
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }
      #endregion

      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (!model.IsDirty) 
            return;
         switch (MessageBox.Show("Do you want to save changes to " + model.FileName, "", MessageBoxButtons.YesNoCancel))
         {
            case DialogResult.Yes:
               model.SaveJson(model.FileName);
               break;
            case DialogResult.No:
               break;
            case DialogResult.Cancel:
               e.Cancel = true;
               break;
         }
      }

      private void testDataToolStripMenuItem_Click(object sender, EventArgs e)
      {    
         model.FillWithTestData(100);
      }
   }
}
