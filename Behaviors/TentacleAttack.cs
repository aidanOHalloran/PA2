using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class TentacleAttack : IAttack
    {
        public void Attack(){
            System.Console.Write("Smother with his tentacles (gross)");
        }
    }
}