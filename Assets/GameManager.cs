////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: GameManager.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that checks if the player goes under a certain amount of lives then enters game over
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private bool gameEnded = false;

    

    // Update is called once per frame
    void Update()
    {
        if(gameEnded)
        {
            return;
        }

        if(PlayerStates.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        SceneManager.LoadScene("End");
    }
}
