using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJsonDump
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new MyObject();
            o.InitTest();
            var s = JsonConvert.SerializeObject(o, Formatting.Indented);
            Console.WriteLine(s);
        }
    }
}
