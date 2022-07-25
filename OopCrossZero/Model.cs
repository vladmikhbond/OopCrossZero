

namespace OopCrossZero
{
   public enum CellState { Empty, Cross, Zero };

   public enum GameState { Continue, CrossWon, ZeroWon, Draw, BadTurn };


   public class Model
   {
      public int Size { private set; get; }

      CellState[] cells;
      int winLen;
      CellState nextTurn = CellState.Cross;

      public Model(int size, int winLen=5)
      {
         Size = size;
         this.winLen = winLen;
         cells = new CellState[Size * Size];
         Array.Fill(cells, CellState.Empty);
      }

      public CellState this[int r, int c]
      {
         private set { cells[r * Size + c] = value; }
         get { return cells[r * Size + c]; }
      }

      public GameState Turn(int r, int c)
      {
         if (r >= Size || c >= Size || this[r, c] != CellState.Empty)
            return GameState.BadTurn;
         this[r, c] = nextTurn;
         nextTurn = nextTurn == CellState.Cross ? CellState.Zero : CellState.Cross;
         return getGameSate();
      }

      public GameState Turn(string turn)
      {
         if (turn.Length < 2)
            return GameState.BadTurn;
         try
         {
            int r = Convert.ToInt32(turn[..1]);
            int c = Convert.ToInt32(turn[1..2]);
            return Turn(r, c);
         }
         catch (FormatException)
         {
            return GameState.BadTurn;
         }
      }

      GameState getGameSate()
      {
         // vertical         
         for (int r = 0; r < Size - winLen; r++)
         {
            for (int c = 0; c < Size; c++)
            {
               bool crossFlag = true;
               bool zeroFlag = true;
               for (int i = 0; i < winLen; i++)
               {
                  if (this[r + i, c] != CellState.Cross) 
                     crossFlag = false;
                  if (this[r + i, c] != CellState.Zero) 
                     zeroFlag = false;
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
