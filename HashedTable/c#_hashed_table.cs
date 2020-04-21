// C:\Windows\Microsoft.NET\Framework64\v3.5\csc.exe c#_hashed_table.cs
using System;
using System.Collections;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "One");
        ht.Add(2, "Two");
        ht.Add(3, "Three");
        ht.Add(4, "Four");
        ht.Add(5, null);
        ht.Add("Fv", "Five");
        ht.Add(8.4F, 8.4);
        ht.Add(8.5F, 8.5F);
        string strValue1 = (string)ht[2];
        string strValue2 = (string)ht["Fv"];
        double fValue1 = (double)ht[8.4F]; // double naar double
        float fValue2 = (float)ht[8.5F]; // float naar float

        Console.WriteLine(strValue1);
        Console.WriteLine(strValue2);
        Console.WriteLine(fValue1);
        Console.WriteLine(fValue2);
        // loop met dict
        foreach (DictionaryEntry item in ht)
          Console.WriteLine("key:{0}, value:{1}",item.Key, item.Value);
        // loop met keys
        Console.WriteLine("***keys***");
        foreach (var key in ht.Keys )
          Console.WriteLine("Key:{0}, Value:{1}",key , ht[key]);
        // loop met values
        Console.WriteLine("***values***");
        foreach (var value in ht.Values)
          Console.WriteLine("Value:{0}", value);
    }
  }
}
