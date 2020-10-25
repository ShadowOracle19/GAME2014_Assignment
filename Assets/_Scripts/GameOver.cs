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
