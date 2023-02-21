public class Monster
{
    public int ID, MaximumDamage, RewardExperience, RewardGold, CurrentHitPoints, MaximumHitPoints;
    public string Name, NamePlural;
    public CountedItemList loot;
    public Monster(int id, string name, string nameplural, int maxdamage, int rewexp, int rewgold, int currhp, int maxhp)
    {
        this.ID = id;
        this.Name = name;
        this.NamePlural = nameplural;
        this.MaximumDamage = maxdamage;
        this.RewardExperience = rewexp;
        this.RewardGold = rewgold;
        this.CurrentHitPoints = currhp;
        this.MaximumHitPoints = maxhp;
    }
    public bool IsAlive() => (CurrentHitPoints > 0) ? true : false;
    public int TakeDamage(int damage)
    {
        CurrentHitPoints = CurrentHitPoints - damage;
        return (CurrentHitPoints < 0) ? CurrentHitPoints = 0 : CurrentHitPoints;
    }
}