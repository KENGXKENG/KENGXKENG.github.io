using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI restartText;

    private int currentScore = 0;
    private int highScore = 0;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
        if (restartText != null) restartText.gameObject.SetActive(false);
    }

    public void AddScore(int value)
    {
        currentScore += value;
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = currentScore.ToString();

        if (highScoreText != null)
            highScoreText.text = "최고 점수: " + highScore.ToString();
    }

    public void SetRestart()
    {
        if (restartText != null)
            restartText.gameObject.SetActive(true);
    }

    public void ResetScore()
    {
        currentScore = 0;
        UpdateUI();
    }
}
