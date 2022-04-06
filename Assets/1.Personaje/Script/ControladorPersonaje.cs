using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    [Header("Caracteristicas")]
    [Space]
    public string nombre;
    public float speed;
    public bool enmantel;

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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mantel"))
        {
            enmantel = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mantel"))
            enmantel = false;
    }
}
