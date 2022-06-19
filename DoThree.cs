using System;

class DoThree
{
   static void Main(string[] args) 
   {
      int q;

      q = 100;
      
      do
      {
         Console.WriteLine("q = " + q);
         q = q - 5 ;
      }while (q >= 10);
   }
}