////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: FollowPath.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Manages the waypoints sent to the Enemy.cs class
///////////////////////////////////////////////////////////////////////////////////////////////
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public static Transform[] points;

    void Awake()
    {
        points = new Transform[transform.childCount];
        
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
}
