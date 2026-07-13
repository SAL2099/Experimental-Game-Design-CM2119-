using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [Header("Scenes")]
    public SceneLoader sceneLoader;

    private bool isGameOver = false;

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        sceneLoader.LoadEnding();
    }

}
