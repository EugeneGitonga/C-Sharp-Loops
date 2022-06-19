using System;

class DoTwo
{
   static void Main(string[] args) 
   {
      int p;

      p = 2;
      
      do
      {
         Console.WriteLine("p = " + p);
         p = p + 2;
      }while (p <= 100);
   }
}