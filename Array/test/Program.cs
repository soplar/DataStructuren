using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> eredivisie = new Dictionary<string, string>();
            eredivisie["eindhoven"] = "psv";
            eredivisie["amsterdam"] = "ajax";
            eredivisie.Add("rotterdam", "feyenoord");
            eredivisie.Remove("amsterdam");
            // tonen van inhoud van dict met linq
            eredivisie.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
            // of 
            string eredivisie_output = string.Join(Environment.NewLine, eredivisie.Select(a => $"{a.Key}: {a.Value}"));
            Console.WriteLine(eredivisie_output);
        }
    }
}
