namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private const int NoOwner = 0;

        public Rock(Point position, int hitPoints)
            : base(position, NoOwner)
        {
            this.HitPoints = hitPoints;
        }

        public int Quantity
        {
            get { return this.HitPoints / 2; }
        }

        public ResourceType Type
        {
            get 
            {
                return ResourceType.Stone;
            }
        }
    }
}
