using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private SceneHandler sceneHandler;

    int storedScene = PlayerPrefs.GetInt("ActiveScene");

    public void NewGame ()
    {
            SceneManager.LoadScene(1);
    }

    public void ResumeGame()
    {
       SceneManager.LoadScene(storedScene);
    }


    public void QuitGame ()
    {
        Application.Quit();
    }




    private void Awake()
    {
        sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
    }




}
