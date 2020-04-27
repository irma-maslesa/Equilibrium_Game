using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField]
    Text time;

    float counter;
    public static float seconds;

    private void Start()
    {
        time = GameObject.Find("Time").GetComponent<Text>();
        counter = 0;
    }


    void Update()
    {
        counter += Time.deltaTime;
        seconds = counter;

        DisplayTime();
    }

    public void DisplayTime()
    {
        int h, m, s;

        m = (int)counter / 60;
        s = (int)counter % 60;

        h = m / 60;
        m %= 60;

        string hh, mm, ss;

        hh = h < 10? "0" + h.ToString() : h.ToString();
        mm = m < 10 ? "0" + m.ToString() : m.ToString();
        ss = s < 10 ? "0" + s.ToString() : s.ToString();

        time.text = h > 0 ? $"Time - {hh}:{mm}:{ss}" : $"Time - {mm}:{ss}";
    }
}
