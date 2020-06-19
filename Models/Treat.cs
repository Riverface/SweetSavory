using System.Collections.Generic;

namespace SweetSavory.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FlavorTreat> Flavors { get; }

        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }
    }
}