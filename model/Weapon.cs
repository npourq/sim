using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    public class Weapon : Part, IOperatable
    {

        public int Damage { get; set; }
        public int Cooldown { get; set; }
        private int currentCooldown;

        public Weapon(string name, int damage, int cooldown, string description) : base(name, description)
        {
            this.Damage = damage;
            this.Cooldown = cooldown;
            this.currentCooldown = cooldown;
        }

        public void Operate(RichTextBox logger)
        { 
            if (currentCooldown == 0)
            {
                this.ParentShip.Enemy.CurrentHealth -= Damage;
                currentCooldown = Cooldown;

                logger.Invoke(new Action(() => logger.AppendText(ParentShip.Name + " fired its '" + this.Name + "' for " + Damage + " damage.\n")));
            }
            else
                currentCooldown -=1;
        }
    }
}
