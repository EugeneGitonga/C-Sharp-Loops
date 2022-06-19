using System;

class WhileOne
{
   static void Main(string[] args) 
   {
      int i;

      i = 1;//Initialization 
      
      while (i <= 10)//Condition
      {
         Console.WriteLine(i);
         i = i + 1;//Updation
      }

      Console.ReadKey();
   }
}