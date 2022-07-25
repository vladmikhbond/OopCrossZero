using OopCrossZero;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsCrossZero
{

   public partial class MainForm : Form
   {
      Field model;

      public MainForm()
      {
         InitializeComponent();
         model = new Field(10);
         new View(model, this);
      }
   }


}
