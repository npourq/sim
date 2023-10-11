using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    internal class RepairModule : Part, IOperatable
    {
        public int RepairAmount { get; set; }
        public int Cooldown { get; set; }

        private int currentCooldown;
        public RepairModule(string name, int repairAmount, string description, int cooldown) : base(name, description)
        {
            RepairAmount = repairAmount;
            this.Cooldown = cooldown;
            this.currentCooldown = cooldown;
        }

        public void Operate(RichTextBox logger)
        {
            if (currentCooldown == 0)
            {
                this.ParentShip.CurrentHealth += RepairAmount;
                currentCooldown = Cooldown;

                logger.Invoke(new Action(() => logger.AppendText(ParentShip.Name + " used its '" + this.Name + "' and repaired " + RepairAmount + " damage.\n")));
            }
            else
                currentCooldown -= 1;
        }
    }
}
