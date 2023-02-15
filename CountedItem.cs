public class CountedItem
{
    public Quest TheQuest;

    public bool IsCompleted;



    public CountedItem(Quest TheQ, bool IsCompl)
    {
        this.TheQuest = TheQ;
        this.IsCompleted = IsCompl;
    }
}
