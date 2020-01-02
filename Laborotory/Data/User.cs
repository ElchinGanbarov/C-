using Data.Amazing;
using System;


namespace Data
{
    public class User
    {
        public string GroupName { get; set; }
        public Admin  MyProperty { get; set; }
        internal byte Age { get; set; }
    }
}
