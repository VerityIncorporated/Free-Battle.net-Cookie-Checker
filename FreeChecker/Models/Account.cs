namespace FreeChecker.Models;

public class Account
{
    public OverviewRoot? Overview { get; set; }
    public PurchaseRoot? AmericanPurchases { get; set; }
    public PurchaseRoot? EuropePurchases { get; set; }
    public PurchaseRoot? AsiaPurchases { get; set; }
}