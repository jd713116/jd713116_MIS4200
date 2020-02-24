using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jd713116_MIS4200.Models
{
    public class DriverDetails
    {
        public int driverDetailsID { get; set; }
        // the next two properties link the orderDetail to the Order
        public int driverId { get; set; }
        public virtual Drivers Drivers { get; set; }
        // the next two properties link the orderDetail to the Product
        public int seriesID { get; set; }
        public virtual Series Series { get; set; }
    }
}