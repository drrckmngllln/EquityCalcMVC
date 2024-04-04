namespace EquityCalculatorMVC.Models;

public class PaymentInfo : BaseEntity
{
    public decimal Amount { get; set; }
    public decimal Interest { get; set; }
    public decimal Insurance { get; set; }
    public decimal Total { get; set; }
}