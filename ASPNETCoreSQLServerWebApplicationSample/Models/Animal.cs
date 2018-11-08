using System;
using System.Collections.Generic;

namespace ASPNETCoreSQLServerWebApplicationSample.Models
{
    public partial class Animal
    {
        public Animal()
        {
            Owner = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Owner> Owner { get; set; }
    }
}
