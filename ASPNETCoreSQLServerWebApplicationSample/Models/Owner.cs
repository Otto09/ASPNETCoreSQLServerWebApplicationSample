using System;
using System.Collections.Generic;

namespace ASPNETCoreSQLServerWebApplicationSample.Models
{
    public partial class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Value { get; set; }
        public int AnimalId { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
