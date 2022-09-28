using PA2.Models;
using PA2.Interfaces;

namespace PA2.Behaviors
{
    public class Defense : IDefend
    {
         public void Defend(){
            System.Console.Write("Defend Himself!");
        }
    }
}