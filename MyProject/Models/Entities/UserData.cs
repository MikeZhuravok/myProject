using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models.Entities
{
    public class UserData
    {
        public int IdUser { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public DateTime BirthDate { set; get; }
        public DateTime EndDiscDate { set; get; }
        public int RoleId { set; get; }
    }
}