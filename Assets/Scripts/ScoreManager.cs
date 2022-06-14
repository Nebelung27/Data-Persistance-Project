using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    private int m_Points;

    public static ScoreManager Instance;

    void Awake()
    {
        Instance = this;
    }
    public void AddPoint(int point)
    {
        m_Points += point;
        ScoreText.text = $"Score : {m_Points}";
    }
    public void CheckForBestScore()
    {
        if (m_Points > MainManager.Instance.bestScore)
        {
            MainManager.Instance.SaveNewBestScore(m_Points);
            UIMainScene.Instance.EditBestScoreTitle();
        }
    }
}
