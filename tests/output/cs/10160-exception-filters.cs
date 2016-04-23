using system;
class Test
{
   void TestExceptionFilter()
   {
      try
      {
         int i = 0;
      }
      catch (Exception e)
         when(DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
      {
         int j = -1;
      }
   }
}

