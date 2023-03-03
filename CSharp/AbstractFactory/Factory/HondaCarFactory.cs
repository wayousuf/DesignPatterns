using System;
using AbstractFactory.Services;

namespace AbstractFactory.Factory
{
	public class HondaCarFactory : ICarFactory
    {
        private readonly HondaProduct hondaProduct;
        private readonly string state;

        public HondaCarFactory(HondaProduct hondaProduct, string state)
		{
            this.hondaProduct = hondaProduct;
            this.state = state;
        }

        public ICarService CreateCarService => new HondaCarService(this.hondaProduct);

        public ITaxService CrateTaxService => new TaxService(state);
    }
}

