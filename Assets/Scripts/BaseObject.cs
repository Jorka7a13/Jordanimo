using UnityEngine;

namespace Game
{
    public abstract class BaseObject : MonoBehaviour
    {
        public enum ObjectType
        {
            Pickable,
            Collectable
        }

        private ObjectType type;

        public BaseObject(ObjectType type)
        {
            this.type = type;

            Game.GetGame().objects.Add(this);
        }

        public virtual void Update()
        { }

        public ObjectType GetObjectType()
        {
            return type;
        }
    }
}