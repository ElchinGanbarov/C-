using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Laborotory.Story
{
   public enum OrderStatus
    {
        Bakalavr,
        Magist,
        Doktorantura
    }
  public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public  OrderStatus Order { get; set; }
        public string FullName()
        {
            return Name +" "+ SurName;
        }
        
    }
    //class Lead 
    //{
    //    public DateTime ApplyAt { get; set; }
    //    public string Channel { get; set; }
    //    public Person _person { get; set; }
       

    //}
    //class Candidate:Lead
    //{
    //    public string LivingAdress { get; set;}
    //    public DateTime MeetingAt { get; set; }
    //     internal override string Fullname()
    //    {
    //        return base.Fullname()+" "+MeetingAt;
    //    }
    //}
}
