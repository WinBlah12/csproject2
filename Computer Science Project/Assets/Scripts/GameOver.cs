using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour //Win's Code
{
    public int wave;
    public GameObject sceneManager;

    void Start()
    {
        
    }

    public void restartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    
    public void Credits()
    {
        SceneManager.LoadScene(6);
    }
}
