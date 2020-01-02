using System;
using System.Collections.Generic;
using System.Text;

namespace INHERIT
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public virtual string FullName()
        {
            return Name + " " + Surname;
        }
        public Person(string phone)
        {
            Phone = phone;
        }
    }
    class Lead : Person
    {
        public string Channel { get; set; }
        public DateTime ApplyTime { get; set; }

        public override string FullName()
        {
            return base.FullName() + " " + Channel;
        }
        public Lead(string channel, string phone) : base(phone)
        {
            Channel = channel;
        }
    }
    class Candidate : Lead
    {
        public string Workingat { get; set; }
        public DateTime MeetingAt { get; set; }
        public override string FullName()
        {
            return base.FullName() + " " + Workingat;
        }
        public Candidate(string workingat, string channel, string phone) : base(channel, phone)
        {
            Workingat = workingat;
        }
    }


}
