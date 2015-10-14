using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models.Entities
{
    public class Discount
    {
        public int IdDiscount { set; get; }
        public int DiscountAmount { set; get; }
        public string UniqCode { set; get; }
    }
}