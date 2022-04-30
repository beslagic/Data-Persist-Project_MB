using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScore : MonoBehaviour
{

    public static HighScore Instance;

    // public variables
    public string Name;
    public int TopScore;

    // private variables
    private bool debugSwitch = true;

    public void Awake()
    {
        // Destroy old instance if exist
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // Create new sInstance
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadTopScore();
    }

    public void Exit()
    {
        HighScore.Instance.SaveTopScore();
    }

    [System.Serializable]
    class SaveTopScoreData
    {
        public string Name;
        public int TopScore;
    }

    public void SaveTopScore()
    {
        SaveTopScoreData data = new SaveTopScoreData();
        data.Name = Name;
        data.TopScore = TopScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        //Debug serialization JSON file for Save 
        if (debugSwitch) { Debug.Log("Serialization JSON: " + json); }
    }
    public void LoadTopScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveTopScoreData data = JsonUtility.FromJson<SaveTopScoreData>(json);

            Name = data.Name;
            TopScore = data.TopScore;
            
            //Debug deserialization JSON Load file  
            if (debugSwitch) { Debug.Log("Deserialization JSON: " + json); }
        }
    }
    
}
