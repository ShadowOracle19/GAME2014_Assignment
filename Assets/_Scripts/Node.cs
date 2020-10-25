////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: Node.cs
//FileType: Visual C# Script
//Author: Lucas Coates
//Student Number: 101172500
//Last Modified On: 10/24/2020 10:27 PM
//Copy Rights: Mana Burn
//Description: Class that controls where the turrets are built
///////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    //public Color hoverColor;

    [Header("Optional")]
    public GameObject turret;

    BuildManager buildManager;
    //private Renderer rend;
    //private Color startColor;
    //void Start()
    //{
    //    rend = GetComponent<Renderer>();
    //    startColor = rend.material.color;
    //}
    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position;
    }

    void OnMouseUp()
    {
        if(!buildManager.CanBuild)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("cant build!"); //TODO: Display on screen
            return;
        }

        //build a turret
        buildManager.BuildTurretOn(this);
    }

    //void OnMouseEnter()
    //{
    //    rend.material.color = hoverColor;
    //}

    //void OnMouseExit()
    //{
    //    rend.material.color = startColor;
    //}
}
