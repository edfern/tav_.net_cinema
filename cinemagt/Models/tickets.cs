using System;
using System.Collections.Generic;

namespace cinemagt.Models
{
    public class tickets
    {
        public tickets()
        {
            this.salesdetail = new HashSet<salesdetail>();
        }
    
        public int idTicket { get; set; }
        public int idFunction { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public Nullable<decimal> price { get; set; }
        public string seat { get; set; }
    
        public virtual Functions Functions { get; set; }
        public virtual ICollection<salesdetail> salesdetail { get; set; }
    }
}
