using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    private void Awake()
    {
        GameObject.Find("InputField").GetComponent<TMP_InputField>().text = PlayerName.Instance.UserName;
    }

    public void StartNew()
    {

        PlayerName.Instance.UserName = GameObject.Find("InputField").GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else 
       //original code to quit Unity player
        Application.Quit();
#endif
    }

}

