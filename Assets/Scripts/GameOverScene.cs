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
    public GameObject NewBestScore;
    // Start is called before the first frame update
    void Start()
    {
        RefreshPoints();
        RefreshMedal();
        RefreshRecord();
    }
    int GetCurrentPoints()
    {
        return PlayerPrefs.GetInt("CurrentPoints", 0);
    }
    void RefreshPoints()
    {
        var points = GetCurrentPoints();
        Score.text = points + " Points!";
    }
    void RefreshMedal()
    {
        var points = GetCurrentPoints();
        medal.sprite = Medals
            .Where(Xmedal => Xmedal.MinimumPoints <= points)
            .OrderBy(Xmedal => Xmedal.MinimumPoints)
            .Last()
            .Image;
    }
    void RefreshRecord()
    {
        var currentPoints = GetCurrentPoints();
        var recordPoints = PlayerPrefs.GetInt("RecordPoints", 0);

        bool isRecord = (currentPoints > recordPoints);

        if (isRecord)
            PlayerPrefs.SetInt("RecordPoints", currentPoints);

        NewBestScore.SetActive(isRecord);
    }

    
}
