////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: StartButtonBehaviour.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that updates when you enter a new round
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI RoundsText;

    void Start()
    {
        RoundsText.text = PlayerStates.Rounds.ToString();
    }
}
