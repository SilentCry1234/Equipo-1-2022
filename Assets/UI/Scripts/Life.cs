using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool recibirdaño;
    public float time;

    public GameObject Lost;

    private void Update()
    {
        if(recibirdaño == false)
        {
            Timer();
        } 

        if (time >= 3f)
        {
            recibirdaño = true;
            time = 0f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (recibirdaño == true)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                vidas -= 1;
                Contenedorr.contenedores.ReducirVida();
            }
        }
        recibirdaño = false;
    }

    public void Timer()
    {
        time += Time.deltaTime;
    }

}
