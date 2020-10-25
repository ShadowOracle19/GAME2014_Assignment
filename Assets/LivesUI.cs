////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: LivesUI.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that changes the amount lives displayed on the screen
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI lives;
    

    // Update is called once per frame
    void Update()
    {       
        lives.text = PlayerStates.Lives.ToString() + " Lives";
        
    }
}
