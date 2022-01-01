namespace RifoZoo.Animals
{
    public sealed class Koala : Marsupial
        {
        public Koala()
        {
        }

        public override string FriendlyName
            {
                get { return $"Koala '{base.FriendlyName}'"; }
            }
        public override string ToString()
        {
            //return base.ToString();
            return FriendlyName;
        }
    }
}

