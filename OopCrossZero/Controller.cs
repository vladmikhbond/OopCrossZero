
namespace OopCrossZero
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
            GameState gameState;
            //if (!DoTurn("Cross"))
            //   break;

            view.Show();
            do
            {
               Console.Write("Cross turn > ");
               string turnStr = Console.ReadLine();
               gameState = model.Turn(turnStr);
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
               gameState = model.Turn(turnStr);
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
