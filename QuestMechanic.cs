public class Questmechanic
{
    public Location Location;

    public Questmechanic(Location location)
    {

        this.Location = location;
    }


    public void Start()
    {
        if(Location.QuestAvailableHere is not null){
                    int number = Convert.ToInt32(Location.QuestAvailableHere);
                    Quest questObject = World.QuestByID(number);
                    Item itemObject = World.ItemByID((number*2));
                    Console.WriteLine(questObject.QuestName);
                    Console.WriteLine(questObject.QuestDescription);
                    Console.WriteLine("do you wish to accept this quest Y/N");
                    string? answer = Console.ReadLine().ToUpper();
                    if(answer == "Y"){
                        Console.Write(" great get to it then ");
                        QuestList.QuestLog.Add(questObject);
                        
                        }
                    
                    if(answer != "Y"){
                        while(answer != "Y"){
                        Console.Write("NO, but i need a YES TO CONTINUE so ANSWER the question again :)");
                        answer = Console.ReadLine();
                        if(answer == "Q"){
                            break;
                        }
                    
                    if(answer == "Q"){
                            break;
                        }
                        }
        }
    }
}
}