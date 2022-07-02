using IndividualTaxCalculator.Entity;

namespace IndividualTaxCalculator.Interface;

public interface ITaxRule
{ 
    TaxPayer CalculateTaxPercentage(TaxPayer taxPayer);
}