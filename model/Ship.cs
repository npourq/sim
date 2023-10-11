using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    public enum HullType
    {
        Frigate = 3,
        Destroyer = 6,
        Cruiser = 9
    }

    public class Ship
    {

        public HullType HullType { get; set; }
        public string? Name { get; set; }

        public Ship Enemy { get; set; }

        public int BaseHealth { get; set; } //base health
        public int CurrentMaxHealth { get; set; } //health after stats and parts

        public int CurrentHealth { get; set; }

        public List<Part>? Parts { get; set; }


        //private List<IOperatable> OperatableParts { get; set; }

        //private List<IApplicable> ApplyableParts { get; set; }

        public Ship(HullType hullType, string? name, Ship enemy, int baseHealth, List<Part>? parts)
        {
            this.HullType = hullType;
            this.Name = name;
            this.Enemy = enemy;
            this.Parts = parts;
            this.BaseHealth = baseHealth;
            this.CurrentMaxHealth = baseHealth;
            this.CurrentHealth = baseHealth;
        }

        public void RecieveDamage()
        {
            
        }

        public void ApplyParts()
        {
            foreach (Part part in this.Parts)
            {
                part.ParentShip = this;
                Console.WriteLine("\n SHIP: " + this.Name + " PARTNAME: " + part.Name);
                if (part is IApplicable)
                {
                    IApplicable p = (IApplicable)part;
                    p.Apply();
                }
            }
        }

        public void ResetStats()
        {
            this.CurrentMaxHealth = BaseHealth;
            this.CurrentHealth = BaseHealth;
        }

        public void UpdateTick(RichTextBox logger)
        {
            foreach (Part part in this.Parts)
            {
                part.ParentShip = this;
                if (part is IOperatable)
                {
                    IOperatable o = (IOperatable)part;
                    o.Operate(logger);
                }
            }
            if(CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
