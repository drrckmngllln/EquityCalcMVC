using EquityCalculatorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EquityCalculatorMVC.Controllers;

public class EquityCalculatorController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CalculateEquity()
    {
        return View();
    }


    [HttpPost("calculator")]
    public async Task<ActionResult<IReadOnlyList<EquitySchedule>>> CalculateEquity(EquityCalculator equityCalculator)
    {
        var equitySchedule = new List<EquitySchedule>();
        decimal balance = equityCalculator.SellingPrice;
        decimal amount = equityCalculator.SellingPrice / equityCalculator.EquityTerm;
        decimal interest = balance * (decimal)0.05;
        decimal insurance = amount * (decimal)0.01;

        for (int i = 0; i <= equityCalculator.EquityTerm - 1; i++)
        {
            decimal GetTotal()
            {
                return amount + interest + insurance;
            }

            var equity = new EquitySchedule
            {
                Id = i + 1,
                Balance = balance - amount,
                DueDate = equityCalculator.ReservationDate.AddMonths(i + 1),
                Term = i + 1,
                PaymentInfo = new List<PaymentInfo>
                {
                    new PaymentInfo
                    {
                        Id = i + 1,
                        Amount = Convert.ToDecimal(amount),
                        Interest = Convert.ToDecimal(interest),
                        Insurance = insurance,
                        Total = GetTotal()
                    }
                }
            };
            equitySchedule.Add(equity);
            balance -= amount;
        }
        return View("CalculateEquity", equitySchedule);
    }

}