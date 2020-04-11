using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OTMS.Context
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string Pwd { get; set; }
        public string Role { get; set; }
       
    }
}
