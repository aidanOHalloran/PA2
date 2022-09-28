using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace PA2.Models
{
    public class Menu
    {
        public int StartMenu()
        {
            bool useSound = PlayWithSound();
            if(useSound == true){
               var uri = "https://www.youtube.com/watch?v=mBDEHnR-GF8";
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = uri
                };
                System.Diagnostics.Process.Start(psi);
            }
            
            Console.Clear();
            
            int startMenuChoice = 0;
            System.Console.WriteLine("\t\t\tPlayer 1:\n\n\t\tPress Enter To Select A Character...");
            Console.ReadKey();
            System.Console.WriteLine();
            System.Console.WriteLine("\t\t1. Jack Sparrow");
            System.Console.WriteLine("\t\t2. Davey Jones");
            System.Console.WriteLine("\t\t3. Will Turner");
            
            try
            {
                startMenuChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message + "\nPress Enter to select a continue...");
                StartMenu();
            }

          if(startMenuChoice < 1 || startMenuChoice > 3)
                {
                    System.Console.WriteLine("Bad Entry\nPress Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    startMenuChoice = 0;
                    System.Console.WriteLine("\t\t\tPlayer 1:\n\n\t\tPress Enter To Select A Character...");
                    Console.ReadKey();
                    System.Console.WriteLine();
                    System.Console.WriteLine("\t\t1. Jack Sparrow");
                    System.Console.WriteLine("\t\t2. Davey Jones");
                    System.Console.WriteLine("\t\t3. Will Turner");
                    
                    try
                    {
                        startMenuChoice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message + "\nPress Enter to select a continue...");
                        StartMenu();
                    }
                        }
                return startMenuChoice;
                    
        }

        public bool PlayWithSound(){
            System.Console.WriteLine("Would you like to play with sound?");
            System.Console.WriteLine("1. Yes");
            System.Console.WriteLine("2. No");
            string stringChoice = Console.ReadLine();
            int intChoice;
            while(!int.TryParse(stringChoice, out intChoice)){
                System.Console.WriteLine("Enter either 1 or 2");
                stringChoice = Console.ReadLine();
            }
            if(intChoice == 1){
                return true;
            }else{
                return false;
            }
        }
    }
}