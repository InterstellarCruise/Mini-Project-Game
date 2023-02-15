public class PlayerQuest
{
    public Quest TheQuest;
    public bool IsCompleted;

    public PlayerQuest(Quest TheQ, bool IsCompl)
    {
        this.TheQuest = TheQ;
        this.IsCompleted = IsCompl;
    }
}
