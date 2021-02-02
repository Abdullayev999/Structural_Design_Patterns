using System;
using System.Collections.Generic;

namespace BridgeTask
{
    class ConsoleWriter : IWriter
    {
        public ConsoleWriter(string path)
        {
            this.path = path;
        }
        public string path { get; set; }
        public void Write(List<string> list)
        {
            foreach (var item in list)          
            {
                Console.WriteLine(item);
            }
        }
    }
}
