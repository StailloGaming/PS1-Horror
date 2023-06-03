using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public DetermineGameStart gameStatus;

    private void FixedUpdate()
    {
        if(gameStatus == false)
        {
            StartCoroutine(ToMainMenu());
            Debug.Log("main menu new");
        }
    }

    public IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(0);
        Debug.Log("main menu");
    }
}
