using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public string currentPlayerName;
    public string bestPlayerName;
    public int bestScore;
    
    public static MainManager Instance;

    public string BestScoreTitle
    {
        get 
        {
            if (bestPlayerName != string.Empty)
                return $"Best Score: {bestPlayerName} : {bestScore}"; 
            
            return "Best Score: no best yet";
        }
    }
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();
    }

    class SaveData
    {
        public string bestPlayerName;
        public int bestScore;
    }

    private void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestPlayerName = bestPlayerName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile", json);
    }
    private void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile";
        
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.bestPlayerName;
            bestScore = data.bestScore;
        }
    }
    public void SaveNewBestScore(int score)
    {
        bestPlayerName = currentPlayerName;
        bestScore = score;
        SaveScore();
    }
}