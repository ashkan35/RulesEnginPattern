using IndividualTaxCalculator.Entity;
using IndividualTaxCalculator.Interface;

namespace IndividualTaxCalculator.Infra.TaxRules;

public class IncomeRule:ITaxRule
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
    {
        if (taxPayer.GrossIncome < 40000) taxPayer.TaxedAmount = 0;
        else
        {
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
        }
        return taxPayer;
    }


}