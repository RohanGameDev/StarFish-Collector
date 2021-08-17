using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
   public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Restart();
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
}
