namespace WinFormsCrossZero
{
   public class XButton : Button
   {
      public string TurnCoords { get; private set; }
      public int Col { get; private set; }
      

      public XButton(string turnCoords)
      {
         TurnCoords = turnCoords;
      }
   }

}
