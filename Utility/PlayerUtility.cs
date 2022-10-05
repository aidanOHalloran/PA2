using PA2.Models;
using PA2.Behaviors;
using PA2.Characters;

namespace PA2.Utility
{
    public class PlayerUtility
    {
        public Player SetPlayer1(int userChoice){
            switch (userChoice){
                case 1: 
                    // System.Console.WriteLine("Selected Jack Sparrow");
                    // Random rand = new Random();
                    // int randMaxPower = rand.Next(0, 100); 
                    // int randAttackStrength = rand.Next(0, randMaxPower);
                    // int randDefenseStrength = rand.Next(0, randMaxPower);

                    // Player player1 = new Player(){
                    //     Name = "Jack Sparrow",
                    //     MaxPower = randMaxPower,
                    //     Health = 100,
                    //     AttackStrength = randAttackStrength,
                    //     DefensePower = randDefenseStrength,
                    // };
                    // player1.AttackBehavior = new DistractOpponent();
                    // player1.AttackBehavior2 = new Parley();
                    // player1.DefendBehavior = new Defense();
                    Player player1 = new JackSparrow();
                    player1.AskUserName();

                    return player1;
                    break;
                case 2:
                    // System.Console.WriteLine("Selected Davy Jones");
                    //  Random rand2 = new Random();
                    // int randMaxPower2 = rand2.Next(0, 100); 
                    // int randAttackStrength2 = rand2.Next(0, randMaxPower2);
                    // int randDefenseStrength2 = rand2.Next(0, randMaxPower2);
                    
                    // Player player2 = new Player(){
                    //     Name = "Davey Jones",
                    //     MaxPower = randMaxPower2,
                    //     Health = 100,
                    //     AttackStrength = randAttackStrength2,
                    //     DefensePower = randDefenseStrength2,
                    // };
                    // player2.AttackBehavior = new FireCannon();
                    // player2.AttackBehavior2 = new TentacleAttack();
                    // player2.DefendBehavior = new Defense();

                    Player player2ex = new DavyJones();
                    player2ex.AskUserName();

                    return player2ex;
                    break;
                case 3: 
                    // System.Console.WriteLine("Selected Will Turner");
                    //  Random rand3 = new Random();
                    // int randMaxPower3 = rand3.Next(0, 100); 
                    // int randAttackStrength3 = rand3.Next(0, randMaxPower3);
                    // int randDefenseStrength3 = rand3.Next(0, randMaxPower3);
                    
                    // Player player3 = new Player(){
                    //     Name = "Will Turner",
                    //     MaxPower = randMaxPower3,
                    //     Health = 100,
                    //     AttackStrength = randAttackStrength3,
                    //     DefensePower = randDefenseStrength3,
                    // };
                    // player3.AttackBehavior = new SwingSword();
                    // player3.AttackBehavior2 = new FirePistol();
                    // player3.DefendBehavior = new Defense();
                    Player player3 = new WillTurner();
                    player3.AskUserName();

                    return player3;
                    break;

                default:
                    System.Console.WriteLine("Bad Entry\nDefaulting to Jack Sparrow...");
                    // Random rand4 = new Random();
                    // int randMaxPower4 = rand4.Next(0, 100); 
                    // int randAttackStrength4 = rand4.Next(0, randMaxPower4);
                    // int randDefenseStrength4 = rand4.Next(0, randMaxPower4);
                    

                    // Player player4 = new Player(){
                    //     Name = "Jack Sparrow",
                    //     MaxPower = randMaxPower4,
                    //     Health = 100,
                    //     AttackStrength = randAttackStrength4,
                    //     DefensePower = randDefenseStrength4,
                    // };
                    // player4.AttackBehavior = new DistractOpponent();
                    // player4.AttackBehavior2 = new Parley();
                    // player4.DefendBehavior = new Defense();
                    Player player4 = new JackSparrow();
                    player4.AskUserName();

                    return player4;
                    break;
            }
        }
        
        public Player SetPlayer2(Player player1)
        {
            // Player player2 = new Player();
            
            System.Console.WriteLine("\t\t\tPlayer 2:\n\t\tSelect a character...");
            if(player1.CharacterName == "Jack Sparrow"){
                            System.Console.WriteLine("1. Davey Jones");
                            System.Console.WriteLine("2. Will Turner");
                            string userInputString; int userInput;
                            userInputString = Console.ReadLine();
                               while(!int.TryParse(userInputString, out userInput))
                               {
                                   Console.Clear();
                                   System.Console.WriteLine("Bad Entry. Press any key to try again.");
                                   Console.ReadKey();
                                   System.Console.WriteLine("1. Davey Jones");
                                   System.Console.WriteLine("2. Will Turner");
                                   userInputString = Console.ReadLine();
                               }
                               if(userInput == 1){
                                   Player player2 = new DavyJones();
                                   player2.AskUserName();
                                   return player2;
                                   
                               }else if(userInput == 2){
                                   Player player2 = new WillTurner();
                                   player2.AskUserName();
                                   return player2;
                               
                            }
                        }
            
                else if(player1.CharacterName == "Davey Jones"){
                System.Console.WriteLine("1. Jack Sparrow");
                System.Console.WriteLine("2. Will Turner");
                string userInputString2; int userInput2;
                userInputString2 = Console.ReadLine();
                    while(!int.TryParse(userInputString2, out userInput2))
                    {
                        Console.Clear();
                        System.Console.WriteLine("Bad Entry. Press any key to try again.");
                        Console.ReadKey();
                        System.Console.WriteLine("1. Jack Sparrow");
                        System.Console.WriteLine("2. Will Turner");
                        userInputString2 = Console.ReadLine();
                    }
                    if(userInput2 == 1){
                        Player player2 = new JackSparrow();
                        player2.AskUserName();
                        return player2;
                        
                    }else if(userInput2 == 2){
                        Player player2 = new WillTurner();
                        player2.AskUserName();
                        return player2;
                }
                
                }else if(player1.CharacterName == "Will Turner"){
                System.Console.WriteLine("1. Jack Sparrow");
                System.Console.WriteLine("2. Davey Jones");
                string userInputString3; int userInput3;
                userInputString3 = Console.ReadLine();

                bool temp = false;

                        while(!int.TryParse(userInputString3, out userInput3) && temp != true)
                        {
                            Console.Clear();
                            System.Console.WriteLine("Bad Entry. Press any key to try again.");
                            Console.ReadKey();
                            System.Console.WriteLine("1. Jack Sparrow");
                            System.Console.WriteLine("2. Davey Jones");
                            userInputString3 = Console.ReadLine();
                        if(userInput3 == 1 || userInput3 == 2){
                            temp = true;
                        }}
                            if(userInput3 == 1){
                        Player player2 = new JackSparrow();
                        player2.AskUserName();
                        return player2;
                        
                    }else if(userInput3 == 2){
                       Player player2 = new DavyJones();
                        player2.AskUserName();
                        return player2;
                        }     
                    }
    return default;
    }


        private bool CheckIf1Or2(int userInput)
        {
            if(userInput == 1 || userInput == 2){
                return true;
            }else{
                return false;
            }
        }

        static public void ShowJustPlayer1Stats(Player player1)
        {
            Console.Clear();
            System.Console.WriteLine($"\t{player1.UserName}'s Stats:\n");
            System.Console.WriteLine($"\tName: {player1.CharacterName}");
            System.Console.WriteLine($"\tHealth: {Math.Round(player1.Health, 2)}");
            System.Console.WriteLine($"\tMax Power: {player1.MaxPower}");
            System.Console.WriteLine($"\tAttack Strength: {player1.AttackStrength}");
            System.Console.WriteLine($"\tDefense Strength: {player1.DefensePower}\n");
            System.Console.WriteLine("\tPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static bool CheckIfDead(Player player1, Player player2)
        {
            if(player1.Health > 0 && player2.Health > 0)
            {
                return false;
            }else{
                return true;
            }
        }

        static public void ShowPlayer1Stats(Player player1, Player player2)
        {
            if(CheckIfDead(player1, player2) == true) {return;} 
            else {
                Console.Clear();
                System.Console.WriteLine($"\t{player1.UserName}'s Stats:\t\t\t{player2.UserName}'s Stats:\n");
                System.Console.WriteLine($"\tName: {player1.CharacterName}\t\tName: {player2.CharacterName}\t\t");
                System.Console.WriteLine($"\tHealth: {Math.Round(player1.Health, 2)}\t\t\tHealth: {Math.Round(player2.Health, 2)}");
                System.Console.WriteLine($"\tMax Power: {player1.MaxPower}\t\t\tMax Power: {player2.MaxPower}");
                System.Console.WriteLine($"\tAttack Strength: {player1.AttackStrength}\t\tAttack Strength: {player2.AttackStrength}");
                System.Console.WriteLine($"\tDefense Strength: {player1.DefensePower}\t\tDefense Strength: {player2.DefensePower}\n");
                System.Console.WriteLine("\tPress any key to continue");
                Console.ReadKey();
                Console.Clear();
        }
    }
        static public void ShowPlayer2Stats(Player player1 ,Player player2)
        {
            if(CheckIfDead(player1, player2) == true) {return;} 
            else {
            Console.Clear();
            System.Console.WriteLine($"\t{player1.UserName}'s Stats:\t\t\t{player2.UserName}'s Stats:\n");
            System.Console.WriteLine($"\tName: {player1.CharacterName}\t\tName: {player2.CharacterName}\t\t");
            System.Console.WriteLine($"\tHealth: {Math.Round(player1.Health, 2)}\t\t\tHealth: {Math.Round(player2.Health, 2)}");
            System.Console.WriteLine($"\tMax Power: {player1.MaxPower}\t\t\tMax Power: {player2.MaxPower}");
            System.Console.WriteLine($"\tAttack Strength: {player1.AttackStrength}\t\tAttack Strength: {player2.AttackStrength}");
            System.Console.WriteLine($"\tDefense Strength: {player1.DefensePower}\t\tDefense Strength: {player2.DefensePower}\n");
            System.Console.WriteLine("\tPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        }
    }
}