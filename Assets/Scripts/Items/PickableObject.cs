namespace Game
{
    //A pickable object that has physics and can be picked up. (and rotated?)

    public class PickableObject : BaseObject
    {
        public PickableObject() : base(ObjectType.Pickable)
        {
        }
    }
}