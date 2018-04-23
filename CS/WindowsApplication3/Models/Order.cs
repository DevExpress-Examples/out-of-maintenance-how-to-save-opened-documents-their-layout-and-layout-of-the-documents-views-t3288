using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXSample.Models {
    public class Order {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductType { get; set; }
    }
}
