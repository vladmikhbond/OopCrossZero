

namespace OopCrossZero0
{
   public enum CellState { Empty, Cross, Zero };

   public class Model
   {
      public int Size { private set; get; }

      CellState[] cells;
      int winLen;

      public Model(int size, int winLen=5)
      {
         Size = size;
         this.winLen = winLen;
         cells = new CellState[Size * Size];
         Array.Fill(cells, CellState.Empty);
      }

      public CellState this[int r, int c]
      {
         set { cells[r * Size + c] = value; } 
         get { return cells[r * Size + c]; }
      }

      public void Turn(string turnStr, CellState state)
      {
         // just stub
         if (state == CellState.Cross) 
            this[0, 0] = state;
         else
            this[1, 1] = state;
      }
   }
}
