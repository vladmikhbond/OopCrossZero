using OopCrossZero;


namespace WinFormsCrossZero
{
   class View
   {
      // cell size
      const int CS = 40;  
      Field model;
      Form owner;
      public XButton[,] xbuttons;


      public View(Field model, Form owner)
      {
         this.model = model;
         this.owner = owner;
         InitializeView();
      }


      private void InitializeView()
      {
         xbuttons = new XButton[model.Size, model.Size];

         for (int r = 0; r < model.Size; r++)
         {
            for (int c = 0; c < model.Size; c++)
            {
               XButton xb = new XButton(r, c);
               xb.Location = new Point(c * CS, r * CS);   // columns first, rows second
               xb.Size = new Size(CS, CS);
               owner.Controls.Add(xb);

               xbuttons[r, c] = xb;
               xb.Click += XButton_Click;
            }
         }
         owner.ClientSize = new Size(model.Size * CS + 5, model.Size * CS + 5);
      }


      private void XButton_Click(object sender, EventArgs e)
      {
         XButton xb = (XButton)sender;
         GameState gameState = model.Turn(xb.Row, xb.Col);

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
               xbuttons[r, c].Text = 
                  model[r, c] == CellState.Cross ? "X" :
                  model[r, c] == CellState.Zero  ? "O" : " ";
            }
         }
      }


      private void Epilog(GameState gameState)
      {
         owner.Text = gameState.ToString();
      }



   }

}
