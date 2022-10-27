namespace FreeChecker.Models;

public class AccountBalance
{
    public string balance { get; set; } = null!;
}

public class AccountDetails
{
    public string Cookie { get; set; } = null!;
    public string firstName { get; set; } = null!;
    public string lastName { get; set; } = null!;
    public string email { get; set; } = null!;
    public string battleTag { get; set; } = null!;
    public string smsProtectPhone { get; set; } = null!;
}

public class AccountSecurityStatus
{
    public bool authenticatorAttached { get; set; }
    public bool smsProtectAttached { get; set; }
}

public class OverviewRoot
{
    public AccountBalance accountBalance { get; set; } = null!;
    public AccountSecurityStatus accountSecurityStatus { get; set; } = null!;
    public AccountDetails accountDetails { get; set; } = null!;
}