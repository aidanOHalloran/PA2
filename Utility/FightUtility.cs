using PA2.Interfaces;
using PA2.Models;
using PA2.Behaviors;
namespace PA2.Utility
{
    public class FightUtility
    {
        public PlayerUtility PlayerUtility = new PlayerUtility();

        static public void Fight(Player player1, Player player2)
        {
            System.Console.WriteLine("Press any key to decide who goes first...");
            Console.ReadKey();
            int first = RandomWhoGoesFirst();
            TellWhoGoesFirst(first, player1, player2);
             do{
                    if(first == 0){
                    if (!CheckIfDead(player1, player2))
                    {
                        Console.Clear();
                        Player1Attacks(player1, player2);
                    }
                    if(!CheckIfDead(player1, player2)){
                        Console.Clear();
                        Player2Attacks(player1, player2);
                    }    
                    }else if(first == 1){
                    if(!CheckIfDead(player1, player2)){
                        Console.Clear();                        
                        Player2Attacks(player1, player2);
                    }
                    if(!CheckIfDead(player1, player2)){
                        Console.Clear();                        
                        Player1Attacks(player1, player2);
                    }
                    }
                }while(player1.Health > 0 && player2.Health > 0);
            AnnounceWinner(player1, player2);
        }

        static public int RandomWhoGoesFirst(){
            Random random = new Random();
            int randomFirst = random.Next(0,2);
            int first = 0;
            if(randomFirst == 0){
                first = 1;
            }else if(randomFirst == 2){
                first = 2;
            }
            return first;
        }

        static void TellWhoGoesFirst(int first, Player player1, Player player2){
            if(first == 0){
                System.Console.WriteLine($"{player1.UserName} attacks first. Press Enter to continue...");
                Console.ReadKey();                
            }else if(first == 1){
                System.Console.WriteLine($"{player2.UserName} attacks first. Press enter to continue...");
                Console.ReadKey();            
            }
        }

        static void Player1Attacks(Player player1, Player player2)
        {
            System.Console.WriteLine($"\tPLAYER 1: {player1.UserName.ToUpper()}\n\tPress enter to attack");
            Console.ReadKey();
            Console.Clear();
            if(player1.UserName == "Jack Sparrow" && player2.UserName == "Will Turner"){
                BoostedAttackOnPlayer2(player1, player2);
            }else if(player1.UserName == "Will Turner" && player2.UserName == "Davey Jones"){
                BoostedAttackOnPlayer2(player1, player2);
            }else if(player1.UserName == "Davey Jones" && player2.UserName == "Jack Sparrow"){
                BoostedAttackOnPlayer2(player1, player2);
            }else{
                RegularAttackOnPlayer2(player1, player2);
            }
            PlayerUtility.ShowPlayer1Stats(player1, player2);
        }

        static void Player2Attacks(Player player1, Player player2)
        {
            System.Console.WriteLine($"\tPLAYER 2: {player2.UserName.ToUpper()}\n\tPress enter to attack");
            Console.ReadKey();
            Console.Clear();
            if(player2.UserName == "Jack Sparrow" && player1.UserName == "Will Turner"){
                BoostedAttackOnPlayer1(player1, player2);
            }else if(player2.UserName == "Will Turner" && player1.UserName == "Davey Jones"){
                BoostedAttackOnPlayer1(player1, player2);
            }else if(player2.UserName == "Davey Jones" && player1.UserName == "Jack Sparrow"){
                BoostedAttackOnPlayer1(player1, player2);
            }else{
                RegularAttackOnPlayer1(player1, player2);
            }
            PlayerUtility.ShowPlayer1Stats(player1, player2);
        }

        static void BoostedAttackOnPlayer2(Player player1, Player player2)
        {
            int attackChoice = Player1WhichAttack(player1, player2);

            if(attackChoice == 1)
                {
                    Console.Clear();
                    System.Console.WriteLine("\t***CRITICAL***");
                double damageDealt = (player1.AttackStrength - player2.DefensePower) * (1.2);
                if(player1.AttackStrength > player2.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player1.UserName + " used "); player1.AttackBehavior.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Attack Power: {player1.AttackStrength}\n{player2.UserName} Defense Power: {player2.DefensePower}");
                    player2.Health = player2.Health - damageDealt;
                }else if(player1.AttackStrength < player2.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player2.UserName + " "); player2.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Defense Power: {player2.DefensePower}\n{player1.UserName} Attack Power: {player1.AttackStrength}");
                    player1.Health = player1.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
                }
            
            else if(attackChoice == 2){
                Console.Clear();
                    System.Console.WriteLine("\t***CRITICAL***");
                double damageDealt = (player1.AttackStrength - player2.DefensePower) * (1.2);
                if(player1.AttackStrength > player2.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player1.UserName + " used "); player1.AttackBehavior2.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Attack Power: {player1.AttackStrength}\n{player2.UserName} Defense Power: {player2.DefensePower}");
                    player2.Health = player2.Health - damageDealt;
                }else if(player1.AttackStrength < player2.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player2.UserName + " "); player2.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Defense Power: {player2.DefensePower}\n{player1.UserName} Attack Power: {player1.AttackStrength}");
                    player1.Health = player1.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }
        }

        static void RegularAttackOnPlayer2(Player player1, Player player2)
        {
            int attackChoice = Player1WhichAttack(player1, player2);
            
            if(attackChoice == 1){
                Console.Clear();
            double damageDealt = (player1.AttackStrength - player2.DefensePower) * (1.0);
            if(player1.AttackStrength > player2.DefensePower){
                System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                System.Console.Write(player1.UserName + " used "); player1.AttackBehavior.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Attack Power: {player1.AttackStrength}\n{player2.UserName} Defense Power: {player2.DefensePower}");
                player2.Health = player2.Health - damageDealt;
            }else if(player1.AttackStrength < player2.DefensePower){
                System.Console.WriteLine("\tATTACK FAILED\n");
               System.Console.Write(player2.UserName + " used "); player2.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Defense Power: {player2.DefensePower}\n{player1.UserName} Attack Power: {player1.AttackStrength}");
                player1.Health = player1.Health + damageDealt;
            }
            System.Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
            }

            else if(attackChoice == 2){
                Console.Clear();
                 double damageDealt = (player1.AttackStrength - player2.DefensePower) * (1.0);
            if(player1.AttackStrength > player2.DefensePower){
                System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                System.Console.Write(player1.UserName + " used "); player1.AttackBehavior2.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Attack Power: {player1.AttackStrength}\n{player2.UserName} Defense Power: {player2.DefensePower}");
                player2.Health = player2.Health - damageDealt;
            }else if(player1.AttackStrength < player2.DefensePower){
                System.Console.WriteLine("\tATTACK FAILED\n");
               System.Console.Write(player2.UserName + " used "); player2.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Defense Power: {player2.DefensePower}\n{player1.UserName} Attack Power: {player1.AttackStrength}");
                player1.Health = player1.Health + damageDealt;
            }
            System.Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
            }
        }

         static void BoostedAttackOnPlayer1(Player player1, Player player2)
        {
            int attackChoice = Player2WhichAttack(player1, player2);

            if(attackChoice == 1){
                Console.Clear();
                System.Console.WriteLine("\t***CRITICAL***");
                double damageDealt = (player2.AttackStrength - player1.DefensePower) * (1.2);
                if(player2.AttackStrength > player1.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player2.UserName + " used "); player2.AttackBehavior.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Attack Power: {player2.AttackStrength}\n{player1.UserName} Defense Power: {player1.DefensePower}");
                    player1.Health = player1.Health - damageDealt;
                }else if(player2.AttackStrength < player1.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player1.UserName + " used "); player1.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Defense Power: {player1.DefensePower}\n{player2.UserName} Attack Power: {player2.AttackStrength}");
                    player2.Health = player2.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }

            else if(attackChoice == 2){
                Console.Clear();
                    System.Console.WriteLine("\t***CRITICAL***");
                double damageDealt = (player2.AttackStrength - player1.DefensePower) * (1.2);
                if(player2.AttackStrength > player1.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player2.UserName + " used "); player2.AttackBehavior2.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Attack Power: {player2.AttackStrength}\n{player1.UserName} Defense Power: {player1.DefensePower}");
                    player1.Health = player1.Health - damageDealt;
                }else if(player2.AttackStrength < player1.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player1.UserName + " used "); player1.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Defense Power: {player1.DefensePower}\n{player2.UserName} Attack Power: {player2.AttackStrength}");
                    player2.Health = player2.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }
        }

        static void RegularAttackOnPlayer1(Player player1, Player player2)
        {
            int attackChoice = Player2WhichAttack(player1, player2);

            if(attackChoice == 1){
                Console.Clear();
                double damageDealt = (player2.AttackStrength - player1.DefensePower) * (1.0);
                if(player2.AttackStrength > player1.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player2.UserName + " used "); player2.AttackBehavior.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Attack Power: {player2.AttackStrength}\n{player1.UserName} Defense Power: {player1.DefensePower}");
                    player1.Health = player1.Health - damageDealt;
                }else if(player2.AttackStrength < player1.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player1.UserName + " used "); player1.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Defense Power: {player1.DefensePower}\n{player2.UserName} Attack Power: {player2.AttackStrength}");
                    player2.Health = player2.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }

            else if(attackChoice == 2){
                Console.Clear();
                    System.Console.WriteLine("\t***CRITICAL***");
                double damageDealt = (player2.AttackStrength - player1.DefensePower) * (1.2);
                if(player2.AttackStrength > player1.DefensePower){
                    System.Console.WriteLine("\tATTACK SUCCESSFUL\n");
                    System.Console.Write(player2.UserName + " used "); player2.AttackBehavior2.Attack(); System.Console.Write($" for {Math.Round(damageDealt, 2)} damage on {player1.UserName}.\n\n{player2.UserName} Attack Power: {player2.AttackStrength}\n{player1.UserName} Defense Power: {player1.DefensePower}");
                    player1.Health = player1.Health - damageDealt;
                }else if(player2.AttackStrength < player1.DefensePower){
                    System.Console.WriteLine("\tATTACK FAILED\n");
                    System.Console.Write(player1.UserName + " used "); player1.DefendBehavior.Defend(); System.Console.Write($" for {Math.Round(-damageDealt, 2)} damage on {player2.UserName}.\n\n{player1.UserName} Defense Power: {player1.DefensePower}\n{player2.UserName} Attack Power: {player2.AttackStrength}");
                    player2.Health = player2.Health + damageDealt;
                }
                System.Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }
        }

        static void AnnounceWinner(Player player1, Player player2)
        {
            Console.Clear();
            if(player1.Health > player2.Health){
                System.Console.WriteLine($"Player 1 ({player1.UserName}) Wins!");
            }else if(player2.Health > player1.Health){
                System.Console.WriteLine($"Player 2 ({player2.UserName}) Wins!");
            }
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

        static int Player1WhichAttack(Player player1, Player player2){
            System.Console.Write($"Select an attack:\n\n1. "); player1.AttackBehavior.Attack(); System.Console.Write("\n2. "); player1.AttackBehavior2.Attack(); System.Console.WriteLine();
            string attackChoiceString = Console.ReadLine();
            int attackChoice;
            while(!int.TryParse(attackChoiceString, out attackChoice)){
                System.Console.WriteLine("Enter either 1 or 2");
                attackChoiceString = Console.ReadLine();
            }if(attackChoice != 1 && attackChoice != 2){
                attackChoice = 1;
            }
        return attackChoice;
        }

        static int Player2WhichAttack(Player player1, Player player2){
            System.Console.Write($"Select an attack:\n\n1. "); player2.AttackBehavior.Attack(); System.Console.Write("\n2. "); player2.AttackBehavior2.Attack(); System.Console.WriteLine();
            string attackChoiceString = Console.ReadLine();
            int attackChoice;
            while(!int.TryParse(attackChoiceString, out attackChoice)){
                System.Console.WriteLine("Enter either 1 or 2");
                attackChoiceString = Console.ReadLine();
            }if(attackChoice != 1 && attackChoice != 2){
                attackChoice = 1;
            }
        return attackChoice;
        }
    }
}