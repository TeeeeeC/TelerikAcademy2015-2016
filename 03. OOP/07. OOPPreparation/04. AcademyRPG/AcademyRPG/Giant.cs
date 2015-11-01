namespace AcademyRPG
{
    using System.Collections.Generic;

    public class Giant : Character, IFighter, IGatherer
    {
        private const int NoOwner = 0;

        private int addAttackPoints;

         public Giant(string name, Point position)
            : base(name, position, NoOwner)
        {
            this.HitPoints = 200;
            this.AttackPoints = 150;
            this.addAttackPoints = 100;
        }

         public int AttackPoints
         {
             get;
             private set;
         }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += this.addAttackPoints;
                this.addAttackPoints = 0;
                return true;
            }

            return false;
        }
    }
}
