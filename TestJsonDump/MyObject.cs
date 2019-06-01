using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJsonDump
{
    public class MyObject
    {
        public int Age { get; set; }
        public int Age2 { get; } = 5;

        public List<string> Names { get; set; } = new List<string>();
        public Dictionary<string, int> NameDatas { get; set; } = new Dictionary<string, int>();

        public void InitTest()
        {
            Age = 1;
            Names.Add("toto");
            Names.Add("titi");

            NameDatas.Add("toto", 1);
            NameDatas.Add("titi", 5);
        }

    }
}
