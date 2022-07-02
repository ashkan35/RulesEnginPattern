using IndividualTaxCalculator.Entity;
using IndividualTaxCalculator.Interface;

namespace IndividualTaxCalculator.Infra;

public class TaxRuleEngine
{
    private readonly IEnumerable<ITaxRule> _rules;

    public TaxRuleEngine(IEnumerable<ITaxRule> rules)
    {
        _rules = rules;
    }

    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
    {
        foreach (var rule in _rules)
        {
            taxPayer.TaxedAmount += rule.CalculateTaxPercentage(taxPayer).TaxedAmount;
        }

        return taxPayer;
    }
}