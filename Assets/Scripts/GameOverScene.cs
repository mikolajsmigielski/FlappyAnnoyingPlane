using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene : MonoBehaviour
{
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        var points = PlayerPrefs.GetInt("CurrentPoints", 0);
        Score.text = points + " Points!";
    }

    
}
