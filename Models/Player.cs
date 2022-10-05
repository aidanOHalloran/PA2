using PA2.Interfaces;
using PA2.Behaviors;
namespace PA2.Models
{
    public class Player
    {
        public string? UserName {get; set;}
        public string CharacterName {get; set;}
        public double MaxPower {get; set;}
        public double Health {get; set;}
        public double AttackStrength {get; set;}
        public double DefensePower {get; set;}

        public IAttack AttackBehavior {get; set;}
        public IAttack AttackBehavior2 {get; set;}
        public IDefend DefendBehavior {get; set;}

        public Player() {
            MaxPower = new Random().Next(1,100);
            Health = 100;
            int MaxPowerInt = Convert.ToInt32(MaxPower);
            AttackStrength = new Random().Next(1,MaxPowerInt);
            DefensePower = new Random().Next(1,MaxPowerInt);
            DefendBehavior = new Defense();
        }

        public void AskUserName(){
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            while (name == ""){
                Console.Clear();
                Console.WriteLine("Please enter a name.");
                name = Console.ReadLine();
            }
            UserName = name;
        }
    }
}   