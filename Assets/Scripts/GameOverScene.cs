using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[System.Serializable]
public class Medal
{
    public Sprite Image;
    public int MinimumPoints;
}


public class GameOverScene : MonoBehaviour
{
    public Text Score;
    public Medal[] Medals;
    public Image medal;
    // Start is called before the first frame update
    void Start()
    {
        RefreshPoints();
        RefreshMedal();
    }

    void RefreshPoints()
    {
        var points = PlayerPrefs.GetInt("CurrentPoints", 0);
        Score.text = points + " Points!";
    }
    void RefreshMedal()
    {
        var points = PlayerPrefs.GetInt("CurrentPoints", 0);
        medal.sprite = Medals
            .Where(Xmedal => Xmedal.MinimumPoints <= points)
            .OrderBy(Xmedal => Xmedal.MinimumPoints)
            .Last()
            .Image;
    }

    
}
