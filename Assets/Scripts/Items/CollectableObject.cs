namespace Game
{
    //A collectable item that can be collected and stored in the player's inventory.

    public class CollectableObject : BaseObject
    {
        public CollectableObject() : base(ObjectType.Collectable)
        {
        }
    }
}