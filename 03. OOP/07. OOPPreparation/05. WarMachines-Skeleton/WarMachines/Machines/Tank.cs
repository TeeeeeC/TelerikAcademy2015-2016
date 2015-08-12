namespace WarMachines.Machines
{
    using System;
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private bool defenseMode;
        private double attackPoints;
        private double defensePoints;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 100;
            this.AttackPoints -= 40;
            this.DefensePoints += 30;
            this.DefenseMode = true;
        }
        public bool DefenseMode
        {
            get 
            { 
                return this.defenseMode; 
            }
            private set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.defenseMode)
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            this.defenseMode = !this.defenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(" *Defense: {0}", this.defenseMode == true ? "ON" : "OFF");

            return result.ToString();
        }
    }
}
