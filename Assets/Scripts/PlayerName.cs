using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    }
    public string getName() 
    {
        return UserName;
    }
}
