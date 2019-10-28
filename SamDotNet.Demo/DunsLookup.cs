using System;
using Newtonsoft.Json;

namespace SamDotNet.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = args[0];
            string duns_number = args[1];

            Sam sam = new Sam(key);
            var result = sam.GetDunsInfo(duns_number);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
