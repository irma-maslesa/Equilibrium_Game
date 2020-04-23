using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    [SerializeField]
    Text time;

    float count = 0;

    void Update()
    {
        count += Time.deltaTime;

        CheckAndDisplay();
    }

    private void CheckAndDisplay()
    {
        int h, m, s;

        m = (int)count / 60;
        s = (int)count % 60;

        h = m / 60;
        m %= 60;

        string hh, mm, ss;

        hh = h < 10? "0" + h.ToString() : h.ToString();
        mm = m < 10 ? "0" + m.ToString() : m.ToString();
        ss = s < 10 ? "0" + s.ToString() : s.ToString();

        time.text = h > 0 ? $"Time - {hh}:{mm}:{ss}" : $"Time - {mm}:{ss}";
    }
}
