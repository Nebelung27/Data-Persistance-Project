using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreTitle;
    public TMP_InputField playerNameInput;

    void Start()
    {
        bestScoreTitle.text = MainManager.Instance.BestScoreTitle;
        playerNameInput.text = MainManager.Instance.bestPlayerName;
    }
    public void StartNew()
    {
        if (playerNameInput.text != string.Empty)
        {
            EditPlayerName();
            SceneManager.LoadScene(1);
        }

        void EditPlayerName()
        {
            MainManager.Instance.currentPlayerName = playerNameInput.text;
        }
    }
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
