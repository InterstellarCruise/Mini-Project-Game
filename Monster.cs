public class Monster
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage;
    public int RewardExperience;
    public int RewardGold;
    public CountedItemList Loot;
    public int CurrentHitPoints;
    public int MaximumHitpoints;

    public Monster(int MonsID, string MonsName, string MonsPlural, int MaxDMG, int RewExp, int RewGold, int CurHitPoints, int MaxHitPoints)

    {
        this.ID = MonsID;
        this.Name = MonsName;
        this.NamePlural = MonsPlural;
        this.MaximumDamage = MaxDMG;
        this.RewardExperience = RewExp;
        this.RewardGold = RewGold;
        this.CurrentHitPoints = CurHitPoints;
    }

}
