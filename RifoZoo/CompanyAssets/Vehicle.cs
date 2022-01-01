using System;

namespace RifoZoo.CompanyAssets
{
    public abstract class Vehicle
    {
        private string _name;
        private string _model;
        private double _price;
        private Brand _brand;
        private DateTime _productionDate;

        public Brand Brand
        {
            get { return _brand; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), $"A {GetType().Name} must have a valid brand. Null is not a valid brand.");

                if (string.IsNullOrWhiteSpace(value.Name))
                    throw new ArgumentException($"The {nameof(Brand)} assigned to a {GetType().Name} must have a valid name.", nameof(value));

                _brand = value;
            }
        }

        public Vehicle()
        {

        }
        public Vehicle(string x)
        {

        }

    }
}

