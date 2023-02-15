public class Quest
{
    public int ID;
    public string QuestName;
    public string QuestDescription;
    public int RewardExperiencePoint;
    public int RewardGold;
    public Item RewardItem;
    public Weapon RewardWeapon;
    public CountedItem QuestCompletionItems;

    public Quest(int QuestID, string Name, string Description, int QuestRewExp, int QuestRewGold, Item QuestRewItem, Weapon QuestRewWeap)
    {
        this.ID = QuestID;
        this.QuestName = Name;
        this.QuestDescription = Description;
        this.RewardExperiencePoint = QuestRewExp;
        this.RewardGold = QuestRewGold;
        this.RewardItem = QuestRewItem;
        this.RewardWeapon = QuestRewWeap;
    }
}
