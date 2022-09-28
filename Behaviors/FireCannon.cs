using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class FireCannon : IAttack
    {
        public void Attack()
        {
           System.Console.Write("Fire His Cannon!");
        }
    }
}