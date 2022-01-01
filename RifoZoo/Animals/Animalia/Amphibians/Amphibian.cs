namespace RifoZoo.Animals.Crocodiles
{
    public abstract class Amphibian : Animal
        {
            public override string FriendlyName
            {
                get { return Name + "" + Description; }
            }
        }
}

