using DogmaSolutions.Contracts;

namespace RifoZoo.CompanyAssets
{
    public class Brand : IHasName
    {
        public Brand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
    //public Brand Brand
    //{
    //    get
    //    {
    //        return _brand;
    //    }
    //    set
    //    {
    //        if (value == null)
    //            throw new ArgumentNullException(nameof(value), $"A{GetType().Name} cannot be null");

    //        if (string.IsNullOrWhiteSpace(value.Name))
    //            throw new ArgumentException($"The {nameof(Brand)} assigned to a {GetType().Name} must have a valid name.", nameof(value));
    //    }
    //}

}

