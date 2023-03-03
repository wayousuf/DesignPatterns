using System;
using AbstractFactory.Services;

namespace AbstractFactory.Factory
{
	public interface ICarFactory
	{
		public ICarService CreateCarService { get; }

		public ITaxService CrateTaxService { get; }
    }
}

