using System;
using AbstractFactory.Services;

namespace AbstractFactory.Factory
{
	public class ToyotaCarFactory : ICarFactory
	{
        private readonly ToyotaProduct toyotaProduct;
        private readonly string state;

        public ToyotaCarFactory(ToyotaProduct toyotaProduct, string state)
		{
            this.toyotaProduct = toyotaProduct;
            this.state = state;
        }

        public ICarService CreateCarService => new ToyotaCarService(this.toyotaProduct);

        public ITaxService CrateTaxService =>  new TaxService(this.state);
    }
}

