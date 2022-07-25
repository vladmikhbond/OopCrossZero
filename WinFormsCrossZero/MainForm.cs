using OopCrossZero;

namespace WinFormsCrossZero
{

   public partial class MainForm : Form
   {
      const int CELL_SIZE = 40;

      Field model = new Field(10);

      CellState nextTurn = CellState.Cross;

      XButton[,] xbuttons;   // for viewing model

      public MainForm()
      {
         InitializeComponent();

         xbuttons = new XButton[model.Size, model.Size];

         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               XButton xb = new XButton($"{r}{c}");
               xb.Location = new Point(c * CELL_SIZE, r * CELL_SIZE);   // columns first, rows second
               xb.Size = new Size(CELL_SIZE, CELL_SIZE);
               Controls.Add(xb);

               xbuttons[r, c] = xb; 
               xb.Click += XButton_Click;
            }
         }

         this.ClientSize = new Size(model.Size * CELL_SIZE + 5, model.Size * CELL_SIZE + 5);
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
               View(model);
               Epilog(gameState);
               break;
            case GameState.Continue:
               View(model);
               nextTurn = (CellState)((int)CellState.Cross + (int)CellState.Zero - (int)nextTurn);
               break;
            case GameState.BadTurn:
               break;
         }

      }

      private void View(Field model)
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

      private void Epilog(GameState gameState)
      {
         Text = gameState.ToString();
      }
   }
}
