using OopCrossZero;

namespace WinFormsCrossZero
{

   public partial class MainForm : Form
   {      
      // cell size
      const int CS = 40;

      Model model = new Model(10);

      XButton[,] xbuttons;


      public MainForm()
      {
         InitializeComponent();
         Initialize();
      }

      void Initialize()
      {
         xbuttons = new XButton[model.Size, model.Size];

         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               XButton xb = new XButton(r, c);
               xb.Location = new Point(c * CS, r * CS);   // columns first, rows second
               xb.Size = new Size(CS, CS);
               this.Controls.Add(xb);

               xbuttons[r, c] = xb;
               xb.Click += XButton_Click;
            }
         }
         this.ClientSize = new Size(model.Size * CS + 5, model.Size * CS + 5);
      }

      void XButton_Click(object sender, EventArgs e)
      {
         XButton xb = (XButton)sender;
         GameState gameState = model.Turn(xb.Row, xb.Col);

         switch (gameState)
         {
            case GameState.CrossWon:
            case GameState.ZeroWon:
            case GameState.Draw:
               ShowModel();
               Epilog(gameState);
               break;
            case GameState.Continue:
               ShowModel();
               break;
            case GameState.BadTurn:
               break;
         }

      }

      void ShowModel()
      {
         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               xbuttons[r, c].Text =
                  model[r, c] == CellState.Cross ? "X" :
                  model[r, c] == CellState.Zero ? "O" : " ";
            }
         }
      }


      void Epilog(GameState gameState)
      {
         this.Text = gameState.ToString();
      }




   }
}
