namespace EquityCalculatorMVC.Models;

public class EquitySchedule : BaseEntity
{
    public decimal Balance { get; set; }
    public DateTime DueDate { get; set; }
    public int Term { get; set; }
    public List<PaymentInfo> PaymentInfo { get; set; }
}