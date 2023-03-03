using System;
namespace AbstractFactory.Services
{
	public class TaxService : ITaxService
    {
        private readonly string state;

        public TaxService(string state)
		{
            this.state = state;
        }

        public decimal TaxPercentage
		{
			get
			{
				switch (state)
				{
					case "TX":
						return 8.25M;
					case "NY":
						return 4.5M;
					default:
                        return default; 
				}
			}
		}
    }
}

