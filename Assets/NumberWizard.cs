using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or lower than my guess");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct");
        Debug.Log("My initial guess is: " + guess);
        max++;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            endGame();
        }

    }

    void nextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess);
    }

    void endGame()
    {
        Debug.Log("Yay I guessed the correct number! I'm a Wizard!");
        Debug.Log("Would you like to play again? Y or N");
        bool end = true;
        while (end)
        {
            if (Input.GetKeyDown(KeyCode.Y))
            {
                end = false;
                StartGame();
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                end = false;
                Debug.Log("Fine, be a sore loser then.");
            }
        }

    }
}