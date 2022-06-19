using System;

class DoSumProduct
{
   static void Main(string[] args) 
   {
      double k, sumEven = 0,productOdd = 1;

      k = 1;
      
      do
      {
         if(k % 2 == 0)
            sumEven = sumEven + k;
         else
            productOdd = productOdd * k;
         k = k + 1;
      }while (k <= 100);

      Console.WriteLine("\nThe sum of all even numbers between 1 and 100 is " + sumEven);
      Console.WriteLine("The product of all odd numbers between 1 and 100 is " + productOdd);
   }
}