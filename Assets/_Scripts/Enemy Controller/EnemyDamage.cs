using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EnemyDamage : MonoBehaviour
{
    public GameObject[] enemies;
    private int damage;
    public TextMeshProUGUI lives;
    public int lifes;
    // Start is called before the first frame update
    void Start()
    {
        //foreach (var enemy in enemyref)
        //{
        //    damage = enemy.getDamage();
        //    Debug.Log(damage);
        //}
        lifes = 100;
        lives.text = lifes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(lifes <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("collide 1");

        foreach (GameObject enemy in enemies)
        {
            if (collision.gameObject == enemy)
            {
                //Debug.Log("collide");
                damage = enemy.GetComponent<FollowPath>().getDamage();
                lifes -= damage;
                lives.text = lifes.ToString();
            }
        }
    }
    
  
}
