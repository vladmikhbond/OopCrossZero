using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCrossZero.Model
{
   public enum CellState { Empty = 0, Cross = 1, Zero = 10};

   public class Field
   {
      public int Size { private set; get;}

      CellState[] cells;

      public Field(int size)
      {
         Size = size;
         cells = new CellState[Size * Size];
         Array.Fill(cells, CellState.Empty);
      }

      public CellState this[int r, int c]
      {
         set { cells[r * Size + c] = value; }
         get { return cells[r * Size + c]; }
      }

      public CellState Turn(string turn, CellState mark)
      {
         this[0, 0] = mark;
         return CellState.Empty;
      }

   }
}
