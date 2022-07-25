using OopCrossZero;
using System.Reflection;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsCrossZero
{

   public partial class MainForm : Form
   {

      Field model = new Field(10);
      View view;


      public MainForm()
      {
         InitializeComponent();
         view = new View(model, this);
      }
   }

   class View
   {
      
      const int CS = 40;  // cell size
      Field model;
      Form owner;
      public XButton[,] xbuttons;
      CellState nextTurn = CellState.Cross;

      public View(Field model, Form owner)
      {
         this.owner = owner;
         this.model = model;
         InitializeView();
      }

      private void InitializeView()
      {
         xbuttons = new XButton[model.Size, model.Size];

         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               XButton xb = new XButton($"{r}{c}");
               xb.Location = new Point(c * CS, r * CS);   // columns first, rows second
               xb.Size = new Size(CS, CS);
               owner.Controls.Add(xb);

               xbuttons[r, c] = xb;
               xb.Click += XButton_Click;
            }
         }
         owner.ClientSize = new Size(model.Size * CS + 5, model.Size * CS + 5);
      }

      private void Epilog(GameState gameState)
      {
         owner.Text = gameState.ToString();
      }



      private void XButton_Click(object sender, EventArgs e)
      {
         XButton xb = (XButton)sender;
         GameState gameState = model.Turn(xb.TurnCoords, nextTurn);

         switch (gameState)
         {
            case GameState.CrossWon:
            case GameState.ZeroWon:
            case GameState.Draw:
               Show();
               Epilog(gameState);
               break;
            case GameState.Continue:
               Show();
               nextTurn = (CellState)((int)CellState.Cross + (int)CellState.Zero - (int)nextTurn);
               break;
            case GameState.BadTurn:
               break;
         }

      }

      private void Show()
      {
         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               int i = (int)model[r, c];
               xbuttons[r, c].Text = " XO".Substring(i, 1);
            }
         }

      }


   }

}
