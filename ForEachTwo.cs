using System; 

class ForEachTwo
{ 
   static void Main(string[] args) 
   { 
      int[] numbers = {1,2,3,4,5,6,7,8,9,10}; 
      int sum = 0;

      foreach(int num in numbers) 
         sum = sum + num;

      Console.WriteLine("\nThe sum of the numbers in the array is " + sum); 
   } 
}
