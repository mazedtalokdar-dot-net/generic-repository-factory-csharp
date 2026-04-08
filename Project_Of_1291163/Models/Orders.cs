using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Of_1291163.Models
{
    public class Orders:CommonFeild
    {
        public string OrderStatus { get; set; }
        public double DelivaryFee{ get; set; }
        public decimal TotalAmount { get; set; }
    }
}
