using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathManager : MonoBehaviour
{

    public GameObject deathScreenCanvas; //Reference to the death screen canvas

    public void Start()
    {
        
    }

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
        Debug.Log("Quit game");
        Time.timeScale = 1f;
        Application.Quit();

    }


}

//when you die, move camera 0.4x 0.5x or -0.4 and -0.5
//every 0.25 second


