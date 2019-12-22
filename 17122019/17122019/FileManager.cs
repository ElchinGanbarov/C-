using System;
using System.Collections.Generic;
using System.Text;

namespace _17122019
{
    class FileManager
    {
        public string Path { get; set; }
        public FileManager(string path)
        {
            this.Path = path;
            Console.WriteLine("nothing");

        }
        public void Write(object data)
        {
            Console.WriteLine(data);
        }
       
        
    }
}
