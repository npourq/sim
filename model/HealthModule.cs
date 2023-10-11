using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    internal class HealthModule : Part, IApplicable
    {

        public float modifier { get; set; }

        public HealthModule(string name, string description, float mod) : base(name, description)
        {
            modifier = mod;
        }

        public void Apply()
        {
            this.ParentShip.CurrentMaxHealth += (int)(this.ParentShip.CurrentMaxHealth * modifier);
            this.ParentShip.CurrentHealth = this.ParentShip.CurrentMaxHealth;
        }
    }
}
