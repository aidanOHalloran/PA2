using PA2.Models;
using PA2.Behaviors;

namespace PA2.Characters
{
    public class DavyJones : Player
    {
        public DavyJones(){
            CharacterName = "Davey Jones";
            AttackBehavior = new FireCannon();
            AttackBehavior2 = new TentacleAttack();
        }
    }
}