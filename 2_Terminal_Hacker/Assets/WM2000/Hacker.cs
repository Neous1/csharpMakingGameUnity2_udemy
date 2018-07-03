using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {
    //Game State
    int level;

    enum Screen
    { 
        MainMenu,
        Password,
        Win
    }
    Screen currentScreen = Screen.MainMenu;

    // Use this for initialization   
    void Start ()
	{
        ShowMainMenu();
	}

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the Police Station");
        Terminal.WriteLine("Enter you Selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "025")
        {
            Terminal.WriteLine(@"Step into the realm, you're bound to get caught And from this worldly life you'll soon depart ~ The Roots");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid selection");
        }
    }

    private void StartGame()
    {
        currentScreen = Screen.Password;
       Terminal.WriteLine("You've entered Level: " + level);
        Terminal.WriteLine("Please enter your passwrord");
    }
}
