using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class DistractOpponent : IAttack
    {
        public void Attack(){
             Console.Write("Distract His Opponent!");
        }
    }
}