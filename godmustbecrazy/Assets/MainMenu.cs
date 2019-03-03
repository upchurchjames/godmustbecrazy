using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Will load things sequentially.
        // Go to build settings, and then drop in TitleMenu and Game scenes (0 and 1, respectively).
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Will quit the game - however, there is no quit button!  Uncomment + make active when/if it is created.
    /*
    public void QuitGame()
    {
        // Makes us aware that the game has quit, since we can't see this in the game tester.
        // Useful for debugging ONLY!
        // Debug.Log("The game has quit!");
        
        // Actually quits the application.
        Application.Quit();
    }
    */

    public void onePlayer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void twoPlayers()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void threePlayers()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void fourPlayers()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void rockMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
}
