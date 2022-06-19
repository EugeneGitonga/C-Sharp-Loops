using System;

class WhileTwo
{
   static void Main(string[] args) 
   {
      int i;

      i = 80;
      
      while (i >= 10)
      {
         Console.Write(i + " ");
         i = i - 2;//Updation
      }
   }
}