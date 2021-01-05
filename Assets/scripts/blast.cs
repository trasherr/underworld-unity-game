using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{
    
    void Start()
    {
        Invoke("blt",0.5f);
    }

   
    void Update()
    {
        
    }

    void blt()
    {
        Object.Destroy(gameObject);
    }
}
