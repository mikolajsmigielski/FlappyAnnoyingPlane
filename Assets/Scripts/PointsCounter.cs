﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    int Points = 0;
    // Start is called before the first frame update
    void Start()
    {
        SavePoints();
        RefreshText();
    }
    public void IncrementPoints()
    {
        Points++;
        SavePoints();
        RefreshText();
    }
    void SavePoints()
    {
        PlayerPrefs.SetInt("CurrentPoints", Points);
    }
    void RefreshText()
    {
        GetComponent<Text>().text = Points + " Points";
    }

}
