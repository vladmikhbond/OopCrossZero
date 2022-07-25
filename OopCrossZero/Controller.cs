
namespace OopCrossZero
{
   public class Controller
   {
      Field field;
      View view;

      public Controller(Field field, View view)
      {
         this.field = field;
         this.view = view;
      }

      public void Run()
      {         
         while (true)
         {
            GameState gameState;

            view.Show();
            do
            {
               Console.Write("Cross turn > ");
               string turnStr = Console.ReadLine();
               gameState = field.Turn(turnStr);
            } 
            while (gameState == GameState.BadTurn);

            if (gameState != GameState.Continue)
            {
               view.Show();
               Console.Write("Cross won!");
               break;
            }

            view.Show();
            do
            {
               Console.Write("Zero turn > ");         
               string turnStr = Console.ReadLine();
               gameState = field.Turn(turnStr);
            }
            while (gameState == GameState.BadTurn);

            if (gameState != GameState.Continue)
            {
               view.Show();
               Console.Write("Zero won!");
               break;
            }
         }
      }

 
   }
}
