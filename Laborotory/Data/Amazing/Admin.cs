using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Amazing
{
  public  class Admin
    {
        public string FullName { get; set; }
        private byte _age { get; set; }
        public byte Age => _age;
        public User user { get; set; }
        public Admin(byte age)
        {
            _age = age;
        }
    }
}
