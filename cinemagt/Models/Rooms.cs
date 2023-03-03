

using System;
using System.Collections.Generic;

namespace cinemagt.Models
{
    public class Rooms
    {
        public Rooms()
        {
            this.Functions = new HashSet<Functions>();
        }
    
        public int idRoom { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> size { get; set; }
    
        public virtual ICollection<Functions> Functions { get; set; }
    }
}
