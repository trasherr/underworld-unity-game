using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    #region Variables

    public CharacterController2D controll;
    public float hstick = 0f;
    public float speed = 50f;
    public Animator ani;
    public bool alive = true;

    bool jump;
    bool crouch = false;
    bool run = false;
    

    #endregion

    #region Mono callbacks

    void Start()
    {

    }

    void Update()
    {
        hstick = Input.GetAxisRaw("Horizontal") * speed;

        if (hstick != 0) run = true;

        ani.SetBool("speed", run);
        run = false;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
            ani.SetBool("jump", true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            crouch = true;
            Debug.Log("crouch");
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            crouch = false;

        }
        ani.SetBool("crouch", crouch);

    }


    void FixedUpdate()
    {
        controll.Move(hstick * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    #endregion

    #region private


    #endregion

    #region public

    public void jumpEvent()
    {
        ani.SetBool("jump", false);
    }

    public void crouchEvent(bool isCrouching)
    {
        ani.SetBool("crouch", isCrouching);
    }

    public void death()
    {
        ani.SetBool("",alive);
    }


    #endregion
}
