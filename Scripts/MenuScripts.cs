using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScripts : MonoBehaviour
{


 

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Globals.PlayScene = 1;
    }
    public void Options()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        SceneManager.LoadScene(2);
    }


}
