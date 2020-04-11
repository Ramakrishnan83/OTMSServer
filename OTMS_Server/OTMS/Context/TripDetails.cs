using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OTMS.Context
{
    public class TripDetails
    {
        [Key]
        public int Trip_id { get; set; }
        public int User_Id { get; set; }
        public string Trip_Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Fare { get; set; }
        public int Duration { get; set; }
    }
}
