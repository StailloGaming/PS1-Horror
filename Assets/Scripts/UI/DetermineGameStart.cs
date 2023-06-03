using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineGameStart : MonoBehaviour
{
    public bool gameStart = false;

    public void GameHasStarted()
    {
        gameStart = true;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    public void GameHasEnded()
    {
        gameStart = false;
        Cursor.lockState = CursorLockMode.None;
    }
}
