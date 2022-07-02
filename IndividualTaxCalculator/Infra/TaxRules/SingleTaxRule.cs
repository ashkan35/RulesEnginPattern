using IndividualTaxCalculator.Entity;
using IndividualTaxCalculator.Interface;

namespace IndividualTaxCalculator.Infra.TaxRules;

public class SingleTaxRule:ITaxRule
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
    {
        if (taxPayer.IsSingle)
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
        return taxPayer;
    }
}