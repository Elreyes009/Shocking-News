using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHelper : MonoBehaviour
{

    public GameObject prota;
    private Animator anim;

    public bool Idle;
    public bool sadIdle;
    public bool sadWalk;
    public bool walk;


    void Start()
    {
        anim = prota.GetComponent<Animator>();
    }

    void Update()
    {
        if (Idle)
        {
            anim.SetBool("Idle", true);
            anim.SetBool("sadIdle", false);
            anim.SetBool("sadWalk", false);
            anim.SetBool("walk", false);
        }
        else if (sadIdle)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("sadIdle", true);
            anim.SetBool("sadWalk", false);
            anim.SetBool("walk", false);
        }
        else if (sadWalk)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("sadIdle", false);
            anim.SetBool("sadWalk", true);
            anim.SetBool("walk", false);
        }
        else if (walk)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("sadIdle", false);
            anim.SetBool("sadWalk", false);
            anim.SetBool("walk", true);
        }




    }
}
