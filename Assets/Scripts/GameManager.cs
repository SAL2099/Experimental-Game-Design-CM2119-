using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Creates the properties in inspector that can be set
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

    //Adds score to total, in this case score is given when interacting with a polaroid but score is quicker to write than collectable or polaroid so we're caling it score
    public void AddScore(int scoreIncrease)
    {
        score += scoreIncrease;
        UpdateScoreUI();
    }

    //Updates total score
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "" +  score;
        }

    }

}
