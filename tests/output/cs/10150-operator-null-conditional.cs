public class test
{
   public static void TestOfNullConditionalOperator()
   {
      string s = "Test";

      if ((s ?.Length > 0))
      {
         s = "Test";
      }
   }
}
