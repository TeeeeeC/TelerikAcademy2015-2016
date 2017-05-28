namespace AcademyRPG
{
    using System.Collections.Generic;
    using System.Linq;

    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;

         public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.attackPoints = 0;
        }

         public int AttackPoints
         {
             get { return this.attackPoints; }
         }

        public int DefensePoints
        {
            get { return int.MaxValue; } //TODO:
        }

     
        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int maxHitPoints = availableTargets.Max(x => x.HitPoints);
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0 && availableTargets[i].HitPoints == maxHitPoints) 
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }
            if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += 2 * resource.Quantity;
                return true;
            }

            return false;
        }

        
    }
}
