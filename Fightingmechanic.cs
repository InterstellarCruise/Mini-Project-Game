public class Fightingmechanic
{
    public Player Player;
    public Monster Monster;
    public Item Item;
    public Fightingmechanic(Player player, Monster monster, Item item)
    {
        this.Player = player;
        this.Monster = monster;
        this.Item = item;
    }

    public void Start()
    {
        var choice1 = "";
        while (choice1 != "A")
        {
            Console.WriteLine($"A: Approach the {Monster.Name}\nC: Change weapon");
            choice1 = Console.ReadLine();
            choice1 = choice1.ToUpper();
            if (choice1 == "C")
            {
                Weapon newweapon = World.Weapons.FirstOrDefault(Weapon => Weapon.ID != Player.CurrentWeapon.ID);
                if (newweapon != null)
                {
                    Player.CurrentWeapon = newweapon;
                    Console.WriteLine($"Your new weapon: {Player.CurrentWeapon.WeaponName}");
                }
                else
                {
                    Console.WriteLine("You don't have any other");
                }
            }

        }

        string winner = "";
        while (winner == "")
        {
            Console.WriteLine($"\n{Player.Name}: {Player.CurrentHitPoints} HP");
            Console.WriteLine($"{Monster.Name}: {Monster.CurrentHitPoints} HP\n");
            Console.WriteLine("A: Attack\nH: Heal up");
            var choice = Console.ReadLine();
            choice = choice.ToUpper();
            if (choice == "A")
            {
                Random rnd = new Random();
                int damagemonster = rnd.Next(1, Monster.MaximumDamage);
                int damageplayer = rnd.Next(Player.CurrentWeapon.MinimnumDamage, Player.CurrentWeapon.MaximumDamage);
                Monster.TakeDamage(damageplayer);
                Player.TakeDamage(damagemonster);
                if (Player.IsAlive() == false)
                {
                    winner = Monster.Name;
                    Console.WriteLine($"You Lost! The {Monster.Name} has {Monster.CurrentHitPoints} HP left!");
                }
                else if (Monster.IsAlive() == false)
                {
                    winner = Player.Name;
                    Console.WriteLine($"\n{Player.Name} was victorious over the scary {Monster.Name}");

                    Console.WriteLine($"You got {Item.Name}!");
                }
            }
            else if (choice == "H")
            {
                while (Player.CurrentHitPoints <= Player.MaximumHitPoints)
                {
                    Player.CurrentHitPoints += 10;
                    Console.WriteLine($"{Player.Name} healed up and now has {Player.CurrentHitPoints} HP");
                }
                Player.CurrentHitPoints = Player.MaximumHitPoints;
                Console.WriteLine($"You have {Player.CurrentHitPoints}, you can't heal anymore!");

            }

        }
    }
}