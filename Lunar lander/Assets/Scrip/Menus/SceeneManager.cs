using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeneManager : MonoBehaviour
{
   public void gameplayButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void exitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
