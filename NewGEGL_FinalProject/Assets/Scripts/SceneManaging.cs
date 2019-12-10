using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public string newScene;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(newScene);
    }

    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Game has quit");
    }
}
