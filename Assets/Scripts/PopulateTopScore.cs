using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopulateTopScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        if (HighScore.Instance.Name.Length > 0) 
        { 
            text.text = "Top Score: "+ HighScore.Instance.Name + ": " + HighScore.Instance.TopScore;
        } else { text.text = ""; }
    }


}
