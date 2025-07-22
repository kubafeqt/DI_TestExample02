namespace DI_TestExample02
{
   public class Builder_InterfaceDI : IToolUser
   {
      private Hammer _hammer;
      private Saw _saw;

      public void BuildHouse()
      {
         _hammer.Use();
         _saw.Use();
         Console.WriteLine("House built.\n");
      }

      public void SetHammer(Hammer hammer)
      {
         _hammer = hammer;
      }

      public void SetSaw(Saw saw)
      {
         _saw = saw;
      }
   }
}

