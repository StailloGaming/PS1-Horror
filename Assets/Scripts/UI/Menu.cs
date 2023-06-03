using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //variables
    public GameObject title;
    public GameObject startButton;
    public GameObject quitButton;
    public DetermineGameStart gameStatus;

    public void StartGame()
    {
        //display main menu
        title.SetActive(false);
        startButton.SetActive(false);
        quitButton.SetActive(false);

        gameStatus.GameHasStarted();
    }

    public void QuitGame()
    {
        Application.Quit();
        gameStatus.GameHasEnded();
    }
}
