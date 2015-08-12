﻿namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
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

        public IPilot Pilot 
        { 
            get
            {
                return this.pilot;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Engaged pilot cannot be null!");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }


        public double AttackPoints
        {
            get;
            protected set;
        }

        public double DefensePoints
        {
            get;
            protected set;
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            string targetsAsString = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets);

            output.AppendLine(string.Format("- {0}", this.Name));
            output.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            output.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            output.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            output.AppendLine(string.Format(" *Defence: {0}", this.DefensePoints));
            output.AppendLine(string.Format(" *Targets: {0}", targetsAsString));

            return output.ToString();
        }
    }
}
