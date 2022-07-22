

namespace OopCrossZero
{
   public class View
   {
      Field field;

      public View(Field field)
      {
         this.field = field;
      }

      public void Show()
      {
         Console.Clear();
         Console.Write("  ");
         for (int c = 0; c < field.Size; c++)
         {
            Console.Write(" " + c);
         }
         Console.WriteLine();

         for (int r = 0; r < field.Size; r++)
         {
            Console.Write(" " + r);
            for (int c = 0; c < field.Size; c++)
            {
               if (field[r, c] == CellState.Cross)
                  Console.Write(" X");
               else if (field[r, c] == CellState.Zero)
                  Console.Write(" O");
               else
                  Console.Write(" .");
            }
            Console.WriteLine();
         }
      }
   }
}
