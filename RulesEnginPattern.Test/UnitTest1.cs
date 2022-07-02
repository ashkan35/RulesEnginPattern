using IndividualTaxCalculator.Entity;
using IndividualTaxCalculator.Services;
using Xunit;

namespace RulesEnginePattern.Test
{
    public class IndividualTaxCalculatorTest
    {
        private TaxCalculatorService _taxCalculator=new ();
        [Fact]
        public void Income_For_Single_TaxPayer()
        {
            //ARRANGE
            TaxPayer taxPayer = new TaxPayer
            {
                GrossIncome = 300000,
                IsSingle = true,
                IsResidentOrCitizen = true,
            };

            //Act
            var result = _taxCalculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(78000, result.TaxedAmount);
        }
    }
}