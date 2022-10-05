using PA2.Models;
using PA2.Behaviors;

namespace PA2.Characters
{
    public class WillTurner : Player
    {
        public WillTurner(){
            CharacterName = "Will Turner";
            AttackBehavior = new SwingSword();
            AttackBehavior2 = new FirePistol();
        }
    }
}