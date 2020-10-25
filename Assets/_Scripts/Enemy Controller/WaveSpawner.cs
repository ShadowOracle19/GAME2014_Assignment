using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;

    public Transform enemyPrefab;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    [Header("UI Text")]
    public TextMeshProUGUI waveCountdownText;
    public TextMeshProUGUI roundText;


    private int waveIndex = 0;

    void Update()
    {
        if(EnemiesAlive > 0)
        {
            return;
        }

        if(countdown <= 0f)
        {
            StartCoroutine(spawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        waveCountdownText.SetText("{00.00}", countdown);
    }

    IEnumerator spawnWave()
    {
        waveIndex++;
        PlayerStates.Rounds++;
        roundText.text = "Rounds: " + PlayerStates.Rounds.ToString();
        //Debug.Log("wave incoming");
        for (int i = 0; i < waveIndex; i++)
        {
            spawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    void spawnEnemy()
    {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        EnemiesAlive++;
    }
}
