using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    [Header("Caracteristicas")]
    [Space]
    public string nombre;
    //private float speed = 7;
    public bool enmantel;
    public bool enmermelada;

    public static ControladorPersonaje instace; 

    private void Awake()
    {
        if(instace == null)
        {
            instace = this;
        }
        else if(instace != this)
        {
            Destroy(instace.gameObject);
            instace = this; 
        }
    }
    private void Update()
    {
        Reducirvelocidad();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mantel"))
        {
            enmantel = true;
        }

        if (collision.gameObject.CompareTag("Mermelada"))
        {
            enmermelada = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mantel"))
        {
            enmantel = false;
        }

        if (collision.gameObject.CompareTag("Mermelada"))
        {
            enmermelada = false;
        }
    }

    public void Reducirvelocidad()
    {
        if (enmermelada == true)
        {
            speed = 0f;
        }

        if (enmermelada == false)
        {
            speed = 7f;
        }
    }

}
