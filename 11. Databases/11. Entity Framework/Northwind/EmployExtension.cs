namespace Northwind
{
    using System.Collections.Generic;
    using System.Data.Linq;

    public class EmployeeExtension : Employee
    {
        public override ICollection<Territory> Territories
        {
            get
            {
                var terr = new EntitySet<Territory>();
                terr.AddRange(base.Territories);
                return terr;
            }
            set
            {
                base.Territories = value;
            }
        }
    }
}
