using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bots : MonoBehaviour
{
    public GameObject blastPrefab;
    public Transform exp_tr;
    public int health = 2;

    GameObject blast;

    
       void Update()
    {
        if (health <= 0)
        {
            dess();
            Debug.Log("destroy");

        }
    }

    public void damage(int power)
    {
        health=health-power;
    }

    void dess()
    {
        Debug.Log("exp");
        blast = Instantiate(blastPrefab, exp_tr.position, exp_tr.rotation) as GameObject;
     
        Object.Destroy(gameObject);
    }


 
}
