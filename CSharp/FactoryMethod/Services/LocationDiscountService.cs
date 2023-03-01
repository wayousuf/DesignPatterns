using System;
namespace FactoryMethod.Services
{
	public class LocationDiscountService : DiscountService
	{
        private readonly string unit;

        public LocationDiscountService(string unit)
		{
            this.unit = unit;
        }

        public override int Percentage
        {
            get
            {
                switch (unit)
                {
                    case "A":
                        return 5;
                    case "B":
                        return 3;
                    default:
                        return 4;
                }
            }
        }
    }
}

