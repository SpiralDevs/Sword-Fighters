using UnityEngine;
using System;
using TMPro;

public class Date : MonoBehaviour
{
    public TMP_Text timeText;
    void Update()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString();
        timeText.text = time;
    }
}
