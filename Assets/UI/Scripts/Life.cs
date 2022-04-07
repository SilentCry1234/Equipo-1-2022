using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool takeDamage;
    public float time;
    
    public GameObject lost;

    private void Update()
    {
        if(takeDamage == false)
        {
            Timer();
        } 

        if (time >= 3f)
        {
            takeDamage = true;
            time = 0f;
        }
        CheckLife();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (takeDamage == true)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                vidas -= 1;
                Contenedorr.contenedores.ReducirVida();
            }
        }
        takeDamage = false;
    }

    public void Timer()
    {
        time += Time.deltaTime;
    }

    private void CheckLife()
    {
        if (vidas <= 0 )
        {
            lost.SetActive(true);            
        }
    }
}
