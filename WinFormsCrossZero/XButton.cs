namespace WinFormsCrossZero
{
   public class XButton : Button
   {
      public int Row { get; private set; }
      public int Col { get; private set; }

      public XButton(int r, int c)
      {
         Row = r;
         Col = c; 
      }
   }

}
