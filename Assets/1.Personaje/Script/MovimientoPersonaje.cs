using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [Header ("Velocidad")]
    [Space]
    private float Velocidad;

    //Direcciones 
    private float Vertical;
    private float Horizontal;

    //Componentes
    private Rigidbody2D rg2D;

    void Start()
    {
        Velocidad = ControladorPersonaje.instace.speed;
        rg2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        movimiento();
    }
    private void movimiento()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        rg2D.velocity = new Vector2(Horizontal * Velocidad, Vertical * Velocidad);

    }
}
