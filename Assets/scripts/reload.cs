using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    public Animator ani;
    public movement move;
    public GameObject winScreen;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "win")
        {
            Time.timeScale = 0f;
            winScreen.SetActive(true);
        }
        if (collision.name != "Tilemap" && collision.name != "win")
        {

            ani.SetTrigger("dead");
            move.enabled = false;
            Invoke("sceneReload", 2f);
            
        }
        
    }

    void sceneReload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
