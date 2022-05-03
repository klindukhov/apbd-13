﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Tutorial13.Entities
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime DateAccepted { get; set; }
        public DateTime DateFinished { get; set; }
        public string Notes { get; set; }
        public int IdClient { get; set; }
        public Customer Customer { get; set; }
        public int IdEmpl { get; set; }
        public Employee Employee { get; set; }
        public ICollection<Confectionery_Order> Сonf_orders { get; set; }

    }
}
