public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Item ItemsRequiredToEnter;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int LocID, string LocName, string LocDescr, Item ItReq, Quest QuestAvHere, Monster MonsHere)

    {
        this.ID = LocID;
        this.Name = LocName;
        this.Description = LocDescr;
        this.ItemsRequiredToEnter = ItReq;
        this.QuestAvailableHere = QuestAvHere;
        this.MonsterLivingHere = MonsHere;
    }

}
//  Location LocN, Location LocE, Location LocS, Location LocW