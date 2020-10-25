using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    public int health = 100;
    public int soulsRecevied = 50;


    private Transform target;

    private int wavepointIndex = 0;

    void Start()
    {
        target = FollowPath.points[0];
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStates.Souls += soulsRecevied;

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if(Vector3.Distance(transform.position, target.position) <= 0.01f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= FollowPath.points.Length - 1)
        {
            EndPath();
            return;
        }
        wavepointIndex++;
        target = FollowPath.points[wavepointIndex];
    }

    void EndPath()
    {
        PlayerStates.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
