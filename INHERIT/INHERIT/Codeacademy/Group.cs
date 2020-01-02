using System;
using System.Collections.Generic;
using System.Text;

namespace INHERIT.Codeacademy
{
    class Group
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Room Room { get; set; }
        public Session Session { get; set; }
    }
}
