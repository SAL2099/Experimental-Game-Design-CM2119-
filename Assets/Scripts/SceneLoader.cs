using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
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
