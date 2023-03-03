using System;
namespace AbstractFactory.Services
{
	public class ToyotaCarService : ICarService
	{
        private readonly ToyotaProduct toyotaProduct;

        public ToyotaCarService(ToyotaProduct toyotaProduct)
		{
            this.toyotaProduct = toyotaProduct;
        }

        public int Cost
        {
            get
            {
                switch (this.toyotaProduct)
                {
                    case ToyotaProduct.Avalon:
                        return 30000;
                    case ToyotaProduct.Camry:
                        return 25000;
                    case ToyotaProduct.Prius:
                        return 35000;
                    case ToyotaProduct.Sienna:
                        return 40000;
                    case ToyotaProduct.Yaris:
                        return 45000;
                    default:
                        return 0;
                }
            }
        }
    }

	public enum ToyotaProduct
	{
        Avalon,
        Camry,
        Prius,
        Yaris,
        Sienna
    }
}

