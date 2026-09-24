using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathManager : MonoBehaviour
{

    public GameObject deathScreenCanvas; //Reference to the death screen canvas

    public void ShowDeathScreen()
    {
        //show the death screen
        deathScreenCanvas.SetActive(true);

        //pause the game
        Time.timeScale = 1f;
    }

    //restart the game (called by a button)

    public void RestartGame()

    {
        //reset time and relad the current scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //quit the game (called by a button)
    public void QuitGame()
    {
        // Reset time scale and quit the application
        Time.timeScale = 1f;
        Application.Quit();

    }
}




