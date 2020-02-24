using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jd713116_MIS4200.Models
{
    public class Drivers
    {
        public int driverId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Hometown { get; set; }
        public ICollection<Series> Series { get; set; }
    }
}