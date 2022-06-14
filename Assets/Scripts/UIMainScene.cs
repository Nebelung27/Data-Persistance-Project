using UnityEngine;
using TMPro;

public class UIMainScene : MonoBehaviour
{
    public TextMeshProUGUI bestScoreTitle;
    
    public static UIMainScene Instance;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        EditBestScoreTitle();
    }
    public void EditBestScoreTitle()
    {
        bestScoreTitle.text = MainManager.Instance.BestScoreTitle;
    }
}
