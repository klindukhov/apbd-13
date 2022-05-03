using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Tutorial13.Entities
{
    public class Confectionery_Order
    {
        public int IdConfection { get; set; }
        public int IdOrder { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public Order Order { get; set; }
        public Confectionery Conf { get; set; }
    }
}
