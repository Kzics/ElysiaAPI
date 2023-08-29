namespace ElysiaAPI.Objects;

public class Character
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public int Money { get; set; }

    public int Bank { get; set; }

    public int BizId { get; set; }

    public int RankId { get; set; }

    public string Skin { get; set; }

    public string Birthday { get; set; }

    public string Commune { get; set; }

    public string IdCard { get; set; }

    public string FullIdCard { get; set; }

    public string Height { get; set; }

    public int SexId { get; set; }

    public string Photo { get; set; }

    public bool HasBCR { get; set; }

    public int PrisonTime { get; set; }

    public string Inventory { get; set; }

    public int Health { get; set; }

    public int Hunger { get; set; }

    public int Thirst { get; set; }

    public bool HasCode { get; set; }

    public bool PermisB { get; set; }

    public int PermisPoints { get; set; }

    public int WorkTime { get; set; }

    public int XP { get; set; }

    public int Level { get; set; }

    public long DrugTime { get; set; }

    public string PhoneNumber { get; set; }

    public float LastPosX { get; set; }

    public float LastPosY { get; set; }

    public float LastPosZ { get; set; }

    public long LastDisconnect { get; set; }

    public int StatDiamond { get; set; }

    public int StatCopper { get; set; }

    public int StatRock { get; set; }

    public int StatTree { get; set; }

    public string UsedClothes { get; set; }

    public long TimestampPermis { get; set; }

    public string WhitelistResponse { get; set; }

    public string WhitelistForm { get; set; }

}