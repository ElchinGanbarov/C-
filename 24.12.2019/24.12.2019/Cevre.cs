using System;
using System.Collections.Generic;
using System.Text;

namespace _24._12._2019
{
    class Cevre
    {
        public byte Width { get; set; }
        public byte Height { get; set; }
        public virtual  int Getarea()
        {

            return Width * Height;
        }

    }
    class Sahe:Cevre
    {
        public override  int Getarea()
        {
            return base.Getarea() / 2;
        }
    }
}
