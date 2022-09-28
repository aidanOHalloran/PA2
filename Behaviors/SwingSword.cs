using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class SwingSword : IAttack
    {
        public void Attack()
        {
            System.Console.Write("Swing His Sword!");
        }
    }
}