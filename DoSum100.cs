using System;

class DoSum100
{
   static void Main(string[] args) 
   {
      int k, sum = 0;

      k = 1;
      
      do
      {
         sum = sum + k;
         k = k + 1;
      }while (k <= 100);

      Console.WriteLine("\nThe sum of all numbers between 1 and 100 is " + sum);
   }
}