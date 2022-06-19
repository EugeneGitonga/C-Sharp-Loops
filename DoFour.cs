using System;

class DoFour
{
   static void Main(string[] args) 
   {
      int q;

      q = 1000;
      
      do
      {
         Console.WriteLine("q = " + q);
         q = q / 2;
      }while (q >= 5);
   }
}