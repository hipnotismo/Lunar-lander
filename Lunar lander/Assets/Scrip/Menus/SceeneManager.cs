using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeneManager : MonoBehaviour
{
    [SerializeField] private AudioSource button;

    public void gameplayButton()
    {
        SceneManager.LoadScene("Gameplay");
        //button.PlayOneShot(clip);
    }

    public void exitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
