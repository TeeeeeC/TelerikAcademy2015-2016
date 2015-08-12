namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        public Fighter(string name, double attackPoints, double defensePoints, bool stealtMode)
            : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = 200;
            this.StealthMode = stealtMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(" *Stealth: {0}", this.StealthMode == true ? "ON" : "OFF");

            return result.ToString();
        }
    }
}
