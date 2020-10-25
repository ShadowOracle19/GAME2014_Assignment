using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public GameObject explosion;
    public float speed = 70f;
    public int damage = 50;

    public void Seek(Transform _Target)
    {
        target = _Target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    
    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(explosion, transform.position, transform.rotation);
        Destroy(effectIns, 1f);        
              
        Damage(target);
        Destroy(gameObject);
    }

    

    void Damage(Transform enemy)
    {
        Enemy e = enemy.GetComponent<Enemy>();

        if (e != null)
        {
            e.TakeDamage(damage);

        }

    }

    
}
