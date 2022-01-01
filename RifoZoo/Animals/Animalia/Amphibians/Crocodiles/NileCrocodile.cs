using RifoZoo.Animals.Amphibians.Crocodiles;

namespace RifoZoo.Animals
{
    public sealed class NileCrocodile : Crocodile
        {
            public override string FriendlyName
            {
                get { return $"Nile {base.FriendlyName}"; }
            }
        }
}

