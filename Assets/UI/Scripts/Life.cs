using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool recibirdaņo;
    public float time;

    public GameObject Lost;

    private void Update()
    {
        if(recibirdaņo == false)
        {
            Timer();
        } 

        if (time >= 3f)
        {
            recibirdaņo = true;
            time = 0f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (recibirdaņo == true)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                vidas -= 1;
                Contenedorr.contenedores.ReducirVida();
            }
        }
        recibirdaņo = false;
    }

    public void Timer()
    {
        time += Time.deltaTime;
    }

}
