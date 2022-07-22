
namespace OopCrossZero
{
   public class Controller
   {
      public static void Run(Field model, View view)
      {
         GameState gameState;
         while (true)
         {
            view.Show();
            do
            {
               Console.Write("Cross turn > ");
               string turn = Console.ReadLine();
               gameState = model.Turn(turn, CellState.Cross);
            } while (gameState == GameState.BadTurn);
            if (gameState != GameState.Continue)
            {
               Console.Write("Cross won!");
               break;
            }

            view.Show();
            do
            {
               Console.Write("Zero turn > ");
               string turn = Console.ReadLine();
               gameState = model.Turn(turn, CellState.Zero);
            } while (gameState == GameState.BadTurn);
            if (gameState != GameState.Continue)
            {
               Console.Write("Zero won!");
               break;
            }
         }
      }


   }
}
