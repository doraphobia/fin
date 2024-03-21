using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeTest : MonoBehaviour
{

    public float timerStartTime;
    public float timerCurrentTime;

    public TextMeshProUGUI timeLabel;

    void Start()
    {
        timerCurrentTime = timerStartTime;
    }

    void Update()
    {
        timerCurrentTime -= Time.deltaTime;
        timeLabel.text = timerCurrentTime.ToString("F0");
        if (timerCurrentTime < 0)
        {
            timerCurrentTime = timerStartTime;
        }


    }
}



