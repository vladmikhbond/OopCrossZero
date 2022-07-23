

namespace OopCrossZero
{
   public enum CellState { Empty, Cross, Zero };

   public enum GameState { Continue, CrossWon, ZeroWon, Draw, BadTurn };


   public class Field
   {
      public int Size { private set; get; }

      CellState[] cells;
      int win;

      public Field(int size, int win=5)
      {
         Size = size;
         this.win = win;
         cells = new CellState[Size * Size];
         Array.Fill(cells, CellState.Empty);
      }

      public CellState this[int r, int c]
      {
         set { cells[r * Size + c] = value; }
         get { return cells[r * Size + c]; }
      }

      public GameState Turn(string turn, CellState mark)
      {
         if (turn.Length < 2)
            return GameState.BadTurn;
         try
         {
            int r = Convert.ToInt32(turn[..1]);
            int c = Convert.ToInt32(turn[1..2]);
            if (r >= Size || c >= Size || this[r, c] != CellState.Empty)
               return GameState.BadTurn;
            this[r, c] = mark;
            return getGameSate();
         }
         catch (FormatException)
         {
            return GameState.BadTurn;
         }
      }

      GameState getGameSate()
      {
         // vertical         
         for (int r = 0; r < Size - win; r++)
         {
            for (int c = 0; c < Size; c++)
            {
               bool crossFlag = true;
               bool zeroFlag = true;
               for (int i = 0; i < win; i++)
               {
                  if (this[r + i, c] != CellState.Cross) crossFlag = false;
                  if (this[r + i, c] != CellState.Zero) zeroFlag = false;
               }
               if (crossFlag) return GameState.CrossWon;
               if (zeroFlag) return GameState.ZeroWon;
            }
         }
         // TODO: horisontal

         // TODO: diagonal

         // TODO: 2-nd diagonal

         return DrawOrContinue();

      }

      GameState DrawOrContinue()
      {
         return cells.All(c => c != CellState.Empty) ? GameState.Draw : GameState.Continue;
      }

      
   }
}
