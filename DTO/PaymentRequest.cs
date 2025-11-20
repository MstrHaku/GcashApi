public class PaymentRequest
{
    public required string Merchant { get; set; }
    public required int Amount { get; set; }
    public required string RedirectToClient { get; set; }
}