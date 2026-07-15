using UnityEngine;
using UnityEngine.SceneManagement;

// Loads different scenes in Unity
public class SceneLoader : MonoBehaviour
{
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene("LevelThree");
    }

    public void LoadLevelFour()
    {
        SceneManager.LoadScene("LevelFour");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadEnding()
    {
        SceneManager.LoadScene("Ending");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
