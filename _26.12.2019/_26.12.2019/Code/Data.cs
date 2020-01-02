using System;
using System.Collections.Generic;
using System.Text;

namespace _26._12._2019
{
    enum OrderStatus 
    {
        Pending,
        Accepted
    }
    class Order
    {
        public OrderStatus Status { get; set; }
    } 
}
