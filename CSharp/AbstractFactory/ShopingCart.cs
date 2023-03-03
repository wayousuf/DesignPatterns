using System;
using AbstractFactory.Factory;
using AbstractFactory.Services;

namespace AbstractFactory
{
	public class ShopingCart
	{
		private ICarService carService;
		private ITaxService taxService;

        public ShopingCart(ICarFactory factory) 
		{
			this.carService = factory.CreateCarService;
			this.taxService = factory.CrateTaxService;
		}

		public decimal Purchase => this.carService.Cost + ((this.taxService.TaxPercentage / 100) * this.carService.Cost);		
	}
}

