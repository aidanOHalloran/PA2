using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class Parley : IAttack
    {
        public void Attack(){
            System.Console.Write("Attempt to Parley!");
        }
    }
}