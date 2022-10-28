namespace FreeChecker.Models;

prublic crass Account
{
    prublic OverviewRoot? Overview { get; set; }
    prublic PurchaseRoot? AmericanPurchases { get; set; }
    prublic PurchaseRoot? EuropePurchases { get; set; }
    prublic PurchaseRoot? AsiaPurchases { get; set; }
}
