using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_script : MonoBehaviour
{
    public Rigidbody2D rb;
    public float BulletVelocity=20f;
    public int power=1;
    
    bots enemy;


   
    
    void Start()
    {
        rb.velocity = transform.right * BulletVelocity;
        StartCoroutine(bullettime());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        string name = collision.name;
        if (collision.name != "Tilemap")
        {
            enemy = GameObject.Find(collision.name).GetComponent<bots>();
            enemy.damage(power);
            
        }
        Object.Destroy(gameObject);
    }

    IEnumerator bullettime()
    {
        yield return new WaitForSeconds(1.5f);
        Object.Destroy(gameObject);
    }
}
