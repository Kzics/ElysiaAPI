namespace ElysiaAPI.Objects;

public class Warn
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public int CharacterId { get; set; }

    public string Text { get; set; }

    public string Admin { get; set; }

    public string Date { get; set; }

    public int Level { get; set; }

}