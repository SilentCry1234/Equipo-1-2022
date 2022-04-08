using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionNaranjito : MonoBehaviour
{
    public float checkearRadio;

    public bool DeberiaRotar;

    public LayerMask elPlayer;

    private Transform target;
    private Animator anim;
    public Vector3 dir;

    private bool Esta_aRango_dePersecucion;


    private void Start()
    {

        anim = GetComponentInChildren<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }
    private void Update()
    {
        anim.SetBool("is Moving", Esta_aRango_dePersecucion);
        Esta_aRango_dePersecucion = Physics2D.OverlapCircle(transform.position, checkearRadio, elPlayer);
        

        dir = target.position - transform.position;
        dir.Normalize();
        if (DeberiaRotar)
        {
            anim.SetFloat("X", dir.x);
            anim.SetFloat("Y", dir.y);
        }
    }
}