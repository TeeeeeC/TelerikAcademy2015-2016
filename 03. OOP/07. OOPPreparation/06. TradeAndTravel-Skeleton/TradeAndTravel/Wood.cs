namespace TradeAndTravel
{
    using System.Collections.Generic;

    public class Wood : Item
    {
        const int GeneralWoodValue = 2; //TODO decreases value it is dropped by 1

        public Wood(string name, Location location = null)
            : base(name, Wood.GeneralWoodValue, ItemType.Wood, location)
        {
        }
    }
}
