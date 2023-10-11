using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    public class Part
    {
        public string Name { get; set; }
        public Ship ParentShip { get; set; }

        public string Description { get; set; }

        public Part (string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public Part()
        {
            this.Name = "Empty";
            this.Description = "";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
