using OopCrossZero;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsCrossZero
{

   public partial class MainForm : Form
   {
      Model model;

      public MainForm()
      {
         InitializeComponent();
         model = new Model(10);
         new View(model, this);
      }
   }


}
