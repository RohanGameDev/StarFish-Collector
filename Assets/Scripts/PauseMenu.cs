using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gameisPaused = false;
    public GameObject pauseMenuUI;


    private void Start()
    {
        pauseMenuUI.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (gameisPaused == true)
        {
            TurtleController.FindObjectOfType<TurtleController>().enabled = false;
        }
        else
        {
            TurtleController.FindObjectOfType<TurtleController>().enabled = true;
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameisPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameisPaused = true;
    }

}
