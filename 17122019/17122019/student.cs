using System;
using System.Collections.Generic;
using System.Text;

namespace _17122019
{
    class Size
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        public Size(string name,string surname)
        {
            _name = name;
            _surname = surname;
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
            }
        }
        public string Fullname()
        {
            return this.Name +" "+ this.Surname;
        }
       

            
           
        
       
    }
       
}
