namespace DI_TestExample02
{
   public class Builder_SetterDI
   {
      public Hammer Hammer { get; set; }
      public Saw Saw { get; set; }
      // Setter DI

      public void BuildHouse()
      {
         Hammer.Use();
         Saw.Use();
         Console.WriteLine("House built.\n");
      }
   }
}

