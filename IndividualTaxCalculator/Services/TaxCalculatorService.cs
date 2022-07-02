using IndividualTaxCalculator.Entity;
using IndividualTaxCalculator.Infra;
using IndividualTaxCalculator.Interface;

namespace IndividualTaxCalculator.Services;

public class TaxCalculatorService
{
    public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
    {
        var ruleType = typeof(ITaxRule);
        var rules = GetType().Assembly.GetTypes()
            .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(r => Activator.CreateInstance(r) as ITaxRule);

        var engine = new TaxRuleEngine(rules);

        return engine.CalculateTaxPercentage(taxPayer);
    }
}