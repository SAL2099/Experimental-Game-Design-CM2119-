using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI scoreText;

    [Header("Collectables")]
    public int score = 0;

    [Header("Scenes")]
    public SceneLoader sceneLoader;

    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int scoreIncrease)
    {
        score += scoreIncrease;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "" +  score;
        }

    }

}
