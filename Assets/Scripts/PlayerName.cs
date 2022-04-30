using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class PlayerName : MonoBehaviour
{
    public static PlayerName Instance;

    public string UserName;

    // private variables
    private bool debugSwitch = false;

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
        //LoadPlayerName();
    }
    public void LoadPlayerName() 
    {
        if (PlayerName.Instance.UserName != "")
        GameObject.Find("InputField").GetComponent<TMP_InputField>().text = PlayerName.Instance.UserName; 
           
        
    }
}
