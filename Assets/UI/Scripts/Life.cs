using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool recibirda�o;
    public float time;

    public GameObject Lost;

    private void Update()
    {
        if(recibirda�o == false)
        {
            Timer();
        } 

        if (time >= 3f)
        {
            recibirda�o = true;
            time = 0f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (recibirda�o == true)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                vidas -= 1;
                Contenedorr.contenedores.ReducirVida();
            }
        }
        recibirda�o = false;
    }

    public void Timer()
    {
        time += Time.deltaTime;
    }

}
