using System;

class DoSumEven
{
   static void Main(string[] args) 
   {
      int k, sumEven = 0;

      k = 1;
      
      do
      {
         if(k % 2 == 0)
            sumEven = sumEven + k;
         k = k + 1;
      }while (k <= 100);

      Console.WriteLine("\nThe sum of all even numbers between 1 and 100 is " + sumEven);
   }
}