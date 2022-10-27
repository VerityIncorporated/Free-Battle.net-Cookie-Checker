namespace FreeChecker.Models;

public class GiftClaim
{
    public string productTitle { get; set; } = null!;
}

public class Purchase
{
    public string productTitle { get; set; } = null!;
    public bool? chargeback { get; set; } = null!;
    public string total { get; set; } = null!;
}

public class PurchaseRoot
{
    public List<Purchase> purchases { get; set; } = null!;
    public List<GiftClaim> giftClaims { get; set; } = null!;
}