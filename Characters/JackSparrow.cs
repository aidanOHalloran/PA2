using PA2.Models;
using PA2.Behaviors;

namespace PA2.Characters
{
    public class JackSparrow : Player
    {
        public JackSparrow(){
            CharacterName = "Jack Sparrow";
            AttackBehavior = new DistractOpponent();
            AttackBehavior2 = new Parley();
        }
    }
}