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
}
