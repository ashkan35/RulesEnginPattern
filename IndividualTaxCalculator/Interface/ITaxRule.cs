using IndividualTaxCalculator.Entity;

namespace IndividualTaxCalculator.Interface;

public interface ITaxRule
{ 
    TaxPayer CalculateTaxRule(TaxPayer taxPayer);
}