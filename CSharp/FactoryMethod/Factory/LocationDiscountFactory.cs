using System;
using FactoryMethod.Services;

namespace FactoryMethod.Factory
{
	public class LocationDiscountFactory : DiscountFactory
	{
        private readonly string unit;

        public LocationDiscountFactory(string unit)
		{
            this.unit = unit;
        }

        public override DiscountService CreateDiscountService()
        {
            return new LocationDiscountService(unit);
        }
    }
}

