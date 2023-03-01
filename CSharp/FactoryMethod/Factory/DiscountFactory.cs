using System;
using FactoryMethod.Services;

namespace FactoryMethod.Factory
{
	public abstract class DiscountFactory
	{
		public abstract DiscountService CreateDiscountService();
    }
}

