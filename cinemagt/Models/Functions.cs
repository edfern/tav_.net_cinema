
using System;
using System.Collections.Generic;

namespace cinemagt.Models
{   
    public class Functions
    {
        public Functions()
        {
            this.tickets = new HashSet<tickets>();
        }
    
        public int idFunction { get; set; }
        public Nullable<int> idRoom { get; set; }
        public Nullable<int> idMovie { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string state { get; set; }
        public Nullable<decimal> ticketPrice { get; set; }
    
        public virtual movies movies { get; set; }
        public virtual Rooms Rooms { get; set; }
        public virtual ICollection<tickets> tickets { get; set; }
    }
}
