namespace ElysiaAPI.Objects;

public class Account
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string SteamId { get; set; }

    public int AdminLevel { get; set; }

    public long DeleteTimestamp { get; set; }

    public long BanTimestamp { get; set; }

    public string DiscordId { get; set; }

    public string BanReason { get; set; }

    public string AdminPin { get; set; }

    public string IP { get; set; }

    public int KickCount { get; set; }

    public int BanCount { get; set; }

}