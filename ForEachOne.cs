using System; 

class ForEachOne 
{ 
   static void Main(string[] args) 
   { 
      int[] numbers = {10,20,30,40,50}; 

      foreach (int i in numbers) 
         Console.WriteLine("Value is {0}", i); 
      Console.ReadKey(); 
   } 
}
