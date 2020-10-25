////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: SoulsUI.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that controls the ui text of the souls
///////////////////////////////////////////////////////////////////////////////////////////////
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
