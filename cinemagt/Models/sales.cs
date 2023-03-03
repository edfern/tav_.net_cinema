
using System;
using System.Collections.Generic;

namespace cinemagt.Models
{
    public class sales
    {
        public sales()
        {
            this.salesdetail = new HashSet<salesdetail>();
        }
    
        public int idSale { get; set; }
        public string customerName { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual ICollection<salesdetail> salesdetail { get; set; }
    }
}
