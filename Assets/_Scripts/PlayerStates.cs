﻿using System.Collections;
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
