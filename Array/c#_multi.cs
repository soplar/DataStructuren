// https://www.tutorialsteacher.com/csharp/csharp-multi-dimensional-array


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] arr2d_1 = new int[3,2]{
                                {1, 2}, 
                                {3, 4}, 
                                {5, 6} 
                                };

      // of
      int[,] arr2d_2 = { 
                    {1, 2}, 
                    {3, 4}, 
                    {5, 6} 
                    };
      int[, ,] arr3d = {
                            {
                              { 1, 2, 3 },
                              { 4, 5, 6 }
                            }, 
                            {
                              { 7, 8, 9 },
                              { 10, 11, 12 }
                            } 
                       };
       
      Console.WriteLine(arr2d_1[1,1]); // geeft 4
      Console.WriteLine(arr3d[1,0,1]); // geeft 8 
    }
  }
}
// C:\Windows\Microsoft.NET\Framework64\v3.5\csc.exe c#_multi.cs
