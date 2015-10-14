using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models.Entities
{
    public class Total
    {
        public int ID { set; get; }
        public int UserID { set; get; }
        public int ProductId { set; get; }
        public int DiscountId { set; get; }

    }
}