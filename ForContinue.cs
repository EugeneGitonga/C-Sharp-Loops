using System;

class ForContinue
{
   static void Main(string[] args) 
   {
      int i;
      
      for(i = 1;i <= 10;i++)
      {
         if(i % 6 == 0)
         {
            Console.WriteLine("This is my favourite number!");
            continue;
         }
         Console.WriteLine("i = " + i);
      }

   }
}