using System;

namespace Data
{
    public class User
    {
        public string Name { get; set; }
        internal byte age { get; set; }
        public byte Age => age;
        public User(byte ages)
        {
            age = ages;
        }
    }
}
