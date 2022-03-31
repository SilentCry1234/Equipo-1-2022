using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool recibirda�o = true;
    private void Update()
    {
        vidaa = vidas;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      if (!recibirda�o)
      {
            return;
      }
      if (collision.CompareTag("Enemigo"))
      {
            recibirda�o = false;
            Invoke("Impacto", 1);
            vidas -= 1;
      }
      if (Contenedorr.contenedores != null)
        {
            Contenedorr.contenedores.ReducirVida();
        }
        //if (vidas <= 0)
        //{
        // agregar codigo de GAME OVER 
        //}
    }

    void Impacto()
    {
        recibirda�o = true;
    }
}
