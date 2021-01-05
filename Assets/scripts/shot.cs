using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public Transform barrelStanding;
    public Transform barrelCrouching;
    public GameObject bulletPrefab;
    public Animator ani;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
            ani.SetTrigger("fire");


        }
    }

    void shoot()
    {
        if (ani.GetBool("crouch")) Instantiate(bulletPrefab, barrelCrouching.position, barrelCrouching.rotation);
        else Instantiate(bulletPrefab, barrelStanding.position, barrelStanding.rotation);

    }

    

}