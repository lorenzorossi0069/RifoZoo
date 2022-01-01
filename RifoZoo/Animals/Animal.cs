using DogmaSolutions.Contracts;

namespace RifoZoo.Animals
{
    public abstract class Animal : IHasName, IHasDescription, IHasFriendlyName_Get
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value == null ? "Unknown" : value; }
            }

            public string Description { get; set; }

            public abstract string FriendlyName { get; }

            public bool isAlive { get; private set; } = true;
            public void Kill()
            {
                isAlive = false;
            }
        }
}

