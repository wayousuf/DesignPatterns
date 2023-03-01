using System;
using FactoryMethod.Services;

namespace FactoryMethod.Factory
{
	public class CodeDiscountFactory : DiscountFactory
	{
        private readonly string code;

        public CodeDiscountFactory(string code)
		{
            this.code = code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(code);
        }
    }
}

