using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHelper : MonoBehaviour
{
    [Header("Prota")]
    public GameObject prota;
    private Animator anim;
    public GameObject t;
    public GameObject n;
    public GameObject w;

    [Header("Animations Prota")]
    public bool Idle;
    public bool sadIdle;
    public bool sadWalk;
    public bool walk;

    [Header("CaraProta")]
    public bool WTF;
    public bool normal;
    public bool triste;


    [Header("Jefe")]
    public GameObject jefe;
    public GameObject i;
    public GameObject e;

    [Header("Animations Jefe")]
    public bool Caos;

    [Header("CaraJefe")]
    public bool jefeIdle;
    public bool enojado;





    void Start()
    {
        anim = prota.GetComponent<Animator>();
    }

    void Update()
    {
        Animations();
        Caras();

        if (Caos)
        {
            Animator ann = jefe.GetComponent<Animator>();
            ann.SetBool("Caos", true);
        }
    }

    private void Caras()
    {
        if (WTF)
        {
            w.SetActive(true);
        }
        else
        {
            w.SetActive(false);
        }

        if (normal)
        {
            n.SetActive(true);
        }
        else
        {
            n.SetActive(false);
        }

        if (triste)
        {
            t.SetActive(true);
        }
        else
        {
            t.SetActive(false);
        }


    }

    private void Animations()
    {
        if (Idle)
        {
            anim.SetBool("Idle", true);
            anim.SetBool("SadIdle", false);
            anim.SetBool("SadWalk", false);
            anim.SetBool("Walk", false);
        }
        else if (sadIdle)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("SadIdle", true);
            anim.SetBool("SadWalk", false);
            anim.SetBool("Walk", false);
        }
        else if (sadWalk)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("SadIdle", false);
            anim.SetBool("SadWalk", true);
            anim.SetBool("Walk", false);
        }
        else if (walk)
        {
            anim.SetBool("Idle", false);
            anim.SetBool("SadIdle", false);
            anim.SetBool("SadWalk", false);
            anim.SetBool("Walk", true);
        }
    }




}
