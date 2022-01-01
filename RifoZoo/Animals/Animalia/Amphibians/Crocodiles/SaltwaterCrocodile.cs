using RifoZoo.Animals.Amphibians.Crocodiles;

namespace RifoZoo.Animals
{
    public class SaltwaterCrocodile : Crocodile
        {
            public override string FriendlyName
            {
                get { return $"Saltwater {base.FriendlyName}"; }
            }
        }
}

