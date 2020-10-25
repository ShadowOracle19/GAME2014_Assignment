////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: PlayerStates.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that manages various player data such as souls(currency), lives and rounds 
///////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public static int Souls;
    public int startSouls = 400;

    public static int Lives;
    public int startLives = 20;

    public static int Rounds;


    void Start()
    {
        Souls = startSouls;
        Lives = startLives;

        Rounds = 0;
    }

    
}
