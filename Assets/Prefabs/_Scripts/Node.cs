using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    //public Color hoverColor;

    private GameObject turret;

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

    void OnMouseUp()
    {
        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("cant build!"); //TODO: Display on screen
            return;
        }

        //build a turret
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
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
