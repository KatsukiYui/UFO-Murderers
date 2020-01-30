using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        //start the game and refresh the player and enemy stats bu reseting the level to 1
        LevelSystem.level = 1;

        //switch to the instructions scene
        SceneManager.LoadScene("Instructions", LoadSceneMode.Single);
    }

    public void Options()
    {
        //switch to the options scene
        SceneManager.LoadScene("Options", LoadSceneMode.Single);

    }

    public void Quit()
    {
        //quit the game
        Application.Quit();

    }

    //part of the instructions scene.. Starts the game after reading the instructions
    public void InstructionsRead()
    {
        //switch to the instructions scene
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
