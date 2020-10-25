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
