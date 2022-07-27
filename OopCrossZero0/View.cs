

namespace OopCrossZero0
{
   public class View
   {
      Model model;

      public View(Model model)
      {
         this.model = model;
      }

      public void Show()
      {
         Console.Clear();
         for (int r = 0; r < model.Size; r++)
         {
            //Console.Write(" " + r);
            for (int c = 0; c < model.Size; c++)
            {
               if (model[r, c] == CellState.Cross)
                  Console.Write(" X");
               else if (model[r, c] == CellState.Zero)
                  Console.Write(" O");
               else
                  Console.Write(" .");
            }
            Console.WriteLine();
         }
      }
   }
}
