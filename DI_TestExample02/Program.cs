namespace DI_TestExample02
{

   internal class  Program
   {
      static void Main(string[] args)
      {
         //Constructor DI:
         Hammer hammer = new Hammer();
         Saw saw = new Saw();
         Builder builder = new Builder(hammer, saw);
         builder.BuildHouse();

         //Setter DI:
         Builder_SetterDI builder_SetterDI = new Builder_SetterDI();
         builder_SetterDI.Hammer = hammer; //Inject dependencies via Setters
         builder_SetterDI.Saw = saw; //Inject dependencies via Setters
         builder_SetterDI.BuildHouse();

         //Interface DI:
         Builder_InterfaceDI builder_InterfaceDI = new Builder_InterfaceDI();
         builder_InterfaceDI.SetHammer(hammer);
         builder_InterfaceDI.SetSaw(saw);
         builder_InterfaceDI.BuildHouse();
      }
   }
}

