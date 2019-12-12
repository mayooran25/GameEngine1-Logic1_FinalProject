using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public string newScene;
    public GameObject pauseScreen;
    public CameraMovement camMove;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseScreen.SetActive(true);
            //Time.timeScale = 0;
            GamePaused();
            
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(newScene);
    }

    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Game has quit");
    }

    public void GamePaused()
    {
        Time.timeScale = 0;
        if(camMove != null)
        {
            camMove.enabled = false;
        }
    }

    public void GameResumed()
    {
        Time.timeScale = 1;
        if (camMove != null)
        {
            camMove.enabled = true;
        }
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name/*.ToString()*/);
    }
}
