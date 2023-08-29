namespace ElysiaAPI.Objects;

public class SMS
{
    public int Id { get; set; }

    public int CharacterId { get; set; }

    public string NumberEmitter { get; set; }

    public string NumberReceiver { get; set; }

    public long Timestamp { get; set; }

    public string Message { get; set; }
}