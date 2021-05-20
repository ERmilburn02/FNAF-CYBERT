using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TMP_Text timeDisplay;
    void Update()
    {
        timeDisplay.text = $"{Player.CurrentTime} AM";
    }
}
