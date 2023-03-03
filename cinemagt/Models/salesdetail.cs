using System;
using System.Collections.Generic;
namespace cinemagt.Models
{
    public class salesdetail
    {
        public int idSaleDetail { get; set; }
        public int idSale { get; set; }
        public int idTicket { get; set; }
        public string description { get; set; }
    
        public virtual sales sales { get; set; }
        public virtual tickets tickets { get; set; }
    }
}
