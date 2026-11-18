using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class User
    {
        public int ID { get; set; }//PK
        public string UserName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public bool Role { get; set; }
        public bool IsBlocked { get; set; }
    }
}
