namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> mashines;

        public Pilot(string name)
        {
            this.Name = name;
            this.mashines = new List<IMachine>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.mashines.Add(machine);
        }

        public string Report()
        {
            StringBuilder output = new StringBuilder();

            string pilotName = this.Name;
            string numberOfMachines = this.mashines.Count == 0 ? "no" : this.mashines.Count.ToString();
            string machineWord = this.mashines.Count == 1 ? "machine" : "machines";

            output.Append(string.Format("{0} - {1} {2}", pilotName, numberOfMachines, machineWord));

            if (this.mashines.Count != 0)
            {
                output.AppendLine();
                List<IMachine>  sortedMachines = this.mashines
                                  .OrderBy(h => h.HealthPoints)
                                  .ThenBy(n => n.Name).ToList();

                for(int i = 0; i < sortedMachines.Count; i++)
                {
                    if(i < sortedMachines.Count - 1)
                        output.AppendLine(sortedMachines[i].ToString());
                    else
                        output.Append(sortedMachines[i].ToString());
                }
            }
            return output.ToString();
        }
    }
}
