using PA2.Interfaces;


namespace PA2.Models
{
    public class Player
    {
        public string Name {get; set;}
        public double MaxPower {get; set;}
        public double Health {get; set;}
        public double AttackStrength {get; set;}
        public double DefensePower {get; set;}

        public IAttack AttackBehavior {get; set;}
        public IAttack AttackBehavior2 {get; set;}
        public IDefend DefendBehavior {get; set;}
    }
}   