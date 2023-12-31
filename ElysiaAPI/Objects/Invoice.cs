namespace ElysiaAPI.Objects;

public class Invoice
{
    public int InvoiceId { get; set; }

    public int BizId { get; set; }
    public int CharacterId { get; set; }
    public int Amount { get; set; }
    public bool IsPaid { get; set; }
    public string Reason { get; set; }
}