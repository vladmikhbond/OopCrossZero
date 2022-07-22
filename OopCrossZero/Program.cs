using OopCrossZero.Model;
using OopCrossZero.View;

Field field = new Field(5);
View view = new View(field);

string turn;
while (true)
{

   view.Show();
   Console.Write("Cross turn > ");
   turn = Console.ReadLine();
   field.Turn(turn, CellState.Cross);

   view.Show();
   Console.Write("Zero turn > ");
   turn = Console.ReadLine();
   field.Turn(turn, CellState.Zero);

}

