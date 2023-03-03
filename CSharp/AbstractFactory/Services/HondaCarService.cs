using System;
namespace AbstractFactory.Services
{
	public class HondaCarService : ICarService
	{
        private readonly HondaProduct hondaProduct;

        public HondaCarService(HondaProduct hondaProduct)
		{
            this.hondaProduct = hondaProduct;
        }

        public int Cost
        {
            get
            {
                switch (this.hondaProduct)
                {
                    case HondaProduct.Accord:
                        return 30000;
                    case HondaProduct.Civic:
                        return 25000;
                    case HondaProduct.CRV:
                        return 35000;
                    case HondaProduct.Odyssey:
                        return 40000;
                    case HondaProduct.Passport:
                        return 45000;
                    default:
                        return 0;
                }
            }
        }
    }

	public enum HondaProduct
	{
        Accord,
        Civic,
        CRV,
        Odyssey,
        Passport
    }
}

