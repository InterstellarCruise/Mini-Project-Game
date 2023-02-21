public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Gold;
    public int ExperiencePoints;
    public int Level;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;
    public QuestList QuestList;
    public CountedItemList Inventory;

    public Player(string PlayName, int CurHitPoints, int MaxHitPoints, int PlayerGold, int ExpPoints, int PlayerLevel, Weapon CurWeap, Location CurLoc, QuestList QList, CountedItemList Inv)

    {
        this.Name = PlayName;
        this.CurrentHitPoints = CurHitPoints;
        this.MaximumHitPoints = MaxHitPoints;
        this.Gold = PlayerGold;
        this.ExperiencePoints = ExpPoints;
        this.Level = PlayerLevel;
        this.CurrentWeapon = CurWeap;
        this.CurrentLocation = CurLoc;
        this.QuestList = QList;
        this.Inventory = Inv;
    }

        public bool TryMoveTo(Location newLocation)
    {
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
            return true;
        }
        return false;
    }

        public bool IsAlive() => (CurrentHitPoints > 0) ? true : false;
    public int TakeDamage(int damage)
    {
        CurrentHitPoints = CurrentHitPoints - damage;
        return (CurrentHitPoints < 0) ? CurrentHitPoints = 0 : CurrentHitPoints;
    }
}

