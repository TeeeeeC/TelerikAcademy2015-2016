namespace TradeAndTravel
{
    using System.Linq;

    public class EntensionInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    item = base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
                    break;
            }
            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }
            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }
            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    HandleCraftInteraction(actor, commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor, string name)
        {
            var locationForest = actor.Location as Forest;
            if (locationForest is Forest)
            {
                if (actor.ListInventory().Exists(x => x is Weapon))
                {
                    var item = new Wood(name, actor.Location);
                    actor.AddToInventory(item);
                    this.AddToPerson(actor, item);
                }
            }

            var locationMine = actor.Location as Mine;
            if (locationMine is Mine)
            {
                if (actor.ListInventory().Exists(x => x is Armor))
                {
                    var item = new Iron(name, actor.Location);
                    actor.AddToInventory(item);
                    this.AddToPerson(actor, item);
                }
            }
        }

        private void HandleCraftInteraction(Person actor, string name)
        {
            if (actor.ListInventory().Exists(x => x is Iron))
            {
                if (actor.ListInventory().Exists(x => x is Weapon))
                {
                    var item = new Weapon(name);
                    actor.AddToInventory(item);
                    this.AddToPerson(actor, item);
                    return;
                }
                else
                {
                    var item = new Armor(name);
                    actor.AddToInventory(item);
                    this.AddToPerson(actor, item);
                }
            }
        }
    }
}
