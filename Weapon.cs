public class Weapon
{
    public int ID;
    public string WeaponName;
    public string WeaponPlural;
    public int MinimnumDamage;
    public int MaximumDamage;
    public Weapon(int WeaponID, string Name, string NamePLural, int MinDMG, int MaxDMG)
    {
        this.ID = WeaponID;
        this.WeaponName = Name;
        this.WeaponPlural = NamePLural;
        this.MinimnumDamage = MinDMG;
        this.MaximumDamage = MaxDMG;
    }
}
