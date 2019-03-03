using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int numPlayers;

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
        numPlayers = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void twoPlayers()
    {
        numPlayers = 2;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void threePlayers()
    {
        numPlayers = 3;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void fourPlayers()
    {
        numPlayers = 4;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Will create a pointer for each player present, to pick a character.
    //public void characterSelect()
    //{
    //    for (int i = 1; i <= numPlayers; i++)
    //    {
            
    //    }
    //}
}
