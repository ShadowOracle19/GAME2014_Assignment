using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoulsUI : MonoBehaviour
{
    public TextMeshProUGUI souls;

    // Update is called once per frame
    void Update()
    {
        souls.text = PlayerStates.Souls.ToString();
    }
}
