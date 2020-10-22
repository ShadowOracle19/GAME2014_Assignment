using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    //Array of waypoints to walk from one to the next one 
    public Transform[] waypoints;

    public int damage;
    //walk speed that can be set 
    public float moveSpeed = 2f;

    //Index of current waypoint from which enemy walks
    private int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    public int getDamage()
    {
        return damage;
    }
    private void move()
    {
        //if enemy didnt reach last waypoint it can move
        if(waypointIndex <= waypoints.Length - 1)
        {
            //move enemy from current waypoint to the next one
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            //if enemy reaches waypoint increase index by 1
            if(transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
}
