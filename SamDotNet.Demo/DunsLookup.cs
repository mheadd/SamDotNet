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

            // Instantiate a new object and retrieve DUNS info.
            Sam sam = new Sam(key);
            var result = sam.GetDunsInfo(duns_number);
            Console.WriteLine(JsonConvert.DeserializeObject(result));
        }
    }
}
