
namespace OopCrossZero0
{
   public class Controller
   {
      Model model;
      View view;

      public Controller(Model model, View view)
      {
         this.model = model;
         this.view = view;
      }

      public void Run()
      {         
         while (true)
         {
            view.Show();
            Console.Write("Cross turn > ");
            string turnStr = Console.ReadLine();
            model.Turn(turnStr, CellState.Cross);

            view.Show();
            Console.Write("Zero turn > ");
            turnStr = Console.ReadLine();
            model.Turn(turnStr, CellState.Zero);
         }
      }

 
   }
}
