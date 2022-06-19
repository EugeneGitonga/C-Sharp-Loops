using System;

class DoFourRedone
{
   static void Main(string[] args) 
   {
      double q;

      q = 1000;
      
      do
      {
         Console.WriteLine("q = " + Math.Round(q,2));//rounded off correct to 2 decimal points
         q = q / 2;
      }while (q >= 5);
   }
}