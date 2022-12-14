using PA2.Interfaces;
using PA2.Behaviors;
using PA2.Models;
using PA2.Utility;

Console.Clear();
Menu menu = new Menu();
PlayerUtility playerUtility = new PlayerUtility();

int selectedPlayer = menu.StartMenu();
Player player1 = playerUtility.SetPlayer1(selectedPlayer);
Player player2 = new Player();
Console.Clear();
System.Console.WriteLine($"{player1.UserName} is playing as {player1.CharacterName}.\n");
System.Console.Write($"When attacking, {player1.CharacterName} will either "); player1.AttackBehavior.Attack();System.Console.Write(" or "); player1.AttackBehavior2.Attack(); System.Console.WriteLine();
System.Console.Write($"Likewise, when attacked, {player1.CharacterName} will "); player1.DefendBehavior.Defend(); System.Console.WriteLine("\n");
System.Console.WriteLine("Press any key to continue to player stats");
Console.ReadKey();
PlayerUtility.ShowJustPlayer1Stats(player1);

player2 = playerUtility.SetPlayer2(player1);
Console.Clear();
System.Console.WriteLine($"{player2.UserName} is playing as {player2.CharacterName}.\n");
System.Console.Write($"When attacking, {player2.CharacterName} will either "); player2.AttackBehavior.Attack(); System.Console.Write(" or "); player2.AttackBehavior2.Attack(); System.Console.WriteLine();
System.Console.Write($"Likewise, when attacked, {player2.CharacterName} will "); player2.DefendBehavior.Defend(); System.Console.WriteLine("\n");
System.Console.WriteLine("Press any key to continue to player stats");
Console.ReadKey();
PlayerUtility.ShowPlayer2Stats(player1, player2);


FightUtility.Fight(player1, player2);
