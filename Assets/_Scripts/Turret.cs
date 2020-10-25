using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Turret : MonoBehaviour
{
    private Transform target;

    [Header("Attributes")]
    public float range = 3.5f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;


    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";
    public AudioSource laser;

    public Transform turret;

    public GameObject bulletPrefab;
    public Transform firePoint;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDif = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDif)
            {
                shortestDif = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if(nearestEnemy != null && shortestDif <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }
        //Vector3 dir = target.position - transform.position;
        //Quaternion lookRotation = Quaternion.LookRotation(dir);
        //Vector3 rotation = lookRotation.eulerAngles;

        //turret.rotation = Quaternion.Euler(0f, 0f, -rotation.x);
        float AngleRad = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x);
        float AngleDeg = (180 / Mathf.PI) * AngleRad;
        turret.transform.rotation = Quaternion.Euler(0, 0, AngleDeg);

        if(fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        GameObject BulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = BulletGO.GetComponent<Bullet>();
        laser.Play();
        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }

    
}
