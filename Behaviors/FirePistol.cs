using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class FirePistol : IAttack
    {
        public void Attack(){
            System.Console.Write("Fires His Pistol!");
        }
    }
}