using System;

class DoOne
{
   static void Main(string[] args) 
   {
      int i;

      i = 1;//Initialization 
      
      do
      {
         Console.WriteLine(i);
         i = i + 1;//Updation
      }while (i <= 10);//Condition

      Console.ReadKey();
   }
}