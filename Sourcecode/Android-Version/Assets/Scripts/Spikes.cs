using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    private int CurrentScene;


    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(CurrentScene);
    }
}
