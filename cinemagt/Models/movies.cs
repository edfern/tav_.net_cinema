using System;
using System.Collections.Generic;
namespace cinemagt.Models
{
    public class movies
    {
        public movies()
        {
            this.Functions = new HashSet<Functions>();
        }
    
        public int idMovie { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    
        public virtual ICollection<Functions> Functions { get; set; }
    }
}
