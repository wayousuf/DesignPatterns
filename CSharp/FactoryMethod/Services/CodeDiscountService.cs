using System;
namespace FactoryMethod.Services
{
	public class CodeDiscountService : DiscountService
	{
        private readonly string code;

        public CodeDiscountService(string code)
		{
            this.code = code;
        }

        public override int Percentage
        {
            get => 10;            
        }
    }
}

