namespace EquityCalculatorMVC.Models;

public class CombinedEntity
{
    public EquityCalculator EquityCalculator { get; set; }
    public List<EquitySchedule> EquitySchedule { get; set; }
}