using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour //andrews code
{
    public int currentScene;
    public GameObject completeWaveUI;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current Scene: " + currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        Scene();
    }

    void Scene()
    {
        if (GameObject.Find("Plane1") != null || currentScene != 1 || currentScene != 0)
        {
            currentScene = SceneManager.GetActiveScene().buildIndex;
        }

        if (GameObject.Find("Plane1") != null && currentScene != 1 && currentScene != 0)
        {
            Debug.Log("Current Scene: " + currentScene);
        }

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            currentScene = 1;
        }

        if (GameObject.Find("enemyplane") == null && GameObject.Find("enemyplane (1)") == null && GameObject.Find("enemyplane (2)") == null
            && GameObject.Find("enemyplane (3)") == null && GameObject.Find("enemyplane (4)") == null
            && GameObject.Find("enemyplane (5)") == null && GameObject.Find("enemyplane (6)") == null
            && GameObject.Find("enemyplane (7)") == null
            && SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 1)
        {
            Debug.Log("all dead");

            CompleteWave();
        }
    }

    public void CompleteWave()
    {
        completeWaveUI.SetActive(true);
    }

    public void nextWave()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
