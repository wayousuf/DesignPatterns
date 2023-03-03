using System;
namespace AbstractFactory.Services
{
	public interface ITaxService
	{
		public decimal TaxPercentage { get; }
	}
}

