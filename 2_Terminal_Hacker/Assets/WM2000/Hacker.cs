
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game configuration
    const string menuHint = "You may type menu at any time.";
    string[] level1Passwords = { "Dog", "Cat", "And", "Hat","Fly"};
    string[] level2Passwords = { "Table", "Space", "Ghost", "Index", "Frame"};
    string[] level3Passwords = { "Random", "Magna", "Tower", "Believe", "Cartoon" };
    
    //Game State
    int level;

    enum Screen
    { 
        MainMenu,
        Password,
        Win
    }
    Screen currentScreen;
    string password;

    // Use this for initialization   
    void Start ()
	{
        ShowMainMenu();
	}

    void Update()
    {
        int index = Random.Range(0, level1Passwords.Length);
        print(index);
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for 3-Letters words");
        Terminal.WriteLine("Press 2 for 4-Letters words");
        Terminal.WriteLine("Press 3 for 5-Letters words");
        Terminal.WriteLine("Enter you Selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "quit" || input == "close" || input == "exit")
        {
            Application.Quit();
            Terminal.WriteLine("if you're on the browser close tab");
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }


    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input =="2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else if (input == "025")
        {
            Terminal.WriteLine(@"Step into the realm, you're bound to get caught And from this worldly life you'll soon depart ~ The Roots");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
            Terminal.WriteLine(" ");
            Terminal.WriteLine(menuHint);
        }
    }

    private void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        SetRandomPassword();
        Terminal.WriteLine("Enter your passwrord Hint: " + password.Anagram());
        Terminal.WriteLine(" ");
        Terminal.WriteLine(menuHint);


    }

    private void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                ;
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                ;
                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
                break;
            case 3:
                ;
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
                break;
            default:
                Debug.LogError("Level undefined");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);

    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Have a book ...");
                Terminal.WriteLine(@"
     _ _
 .-. | | |
 |M|_|A|N|
 |A|a|.|.|<\
 |T|r| | | \\
 |H|t|M|Z|  \\      
 | | !| | |  \> 
""""""""""""""""""
"                                );
                break;
            case 2:
                Terminal.WriteLine("Have a key ...");
                Terminal.WriteLine("Play again for a greater challenge.");
                Terminal.WriteLine(@"

               .--.
              /.-. '----------.
              \'-' .--'--''-'-'
               '--'
"                         );

                break;
            case 3:
                Terminal.WriteLine("Have a laptop ...");
                Terminal.WriteLine(@"

   .________________.
   |.--------------.|
   ||  -._ .-.     ||
   ||  -._| | |    ||
   ||  -._|'|'|    ||
   ||______________||
  /.-.-.-.-.-.-.-.-.\
 /.-.-.-.-.-.-.-.-.-.\
/____/__________\___o_\ 
\_____________________/

"                         );


                break;
            default:
                Debug.LogError("Not a good place to be !");
                break;
        }

    }
}
