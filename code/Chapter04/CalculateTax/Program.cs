using static System.Console;
public class CalculateTaxApp
{
    public static void Main(string[] args)
    {
        decimal taxToPay = CalculateTax(amount: 1000, twoLetterRegionCode: "GB");
        WriteLine($"You must pay {taxToPay} in tax.");
    }
    static decimal CalculateTax(
    decimal amount, string twoLetterRegionCode)
    {
        decimal rate = 0.0M;
        switch (twoLetterRegionCode)
        {
            case "CH": // Switzerland
                rate = 0.08M;
                break;
            case "GB": // United Kingdom
            case "FR": // France
                rate = 0.2M;
                break;
            case "OR": // Oregon
            case "AK": // Alaska
            case "MT": // Montana
                rate = 0.0M;
                break;
            case "ND": // North Dakota
            case "WI": // Wisconsin
            case "ME": // Maine
            case "VA": // Virginia
                rate = 0.05M;
                break;
            default: // most US states
                rate = 0.06M;
                break;
        }
        return amount * rate;
    }
}