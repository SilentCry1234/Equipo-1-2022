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
    private Animator Animator;

    void Start()
    {
        Velocidad = ControladorPersonaje.instace.speed;
        rg2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        movimiento();
        animaciones();
    }
    private void movimiento()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        rg2D.velocity = new Vector2(Horizontal * Velocidad, Vertical * Velocidad);
    }

    private void animaciones()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Animator.SetBool("Camina para atras", true); 
        }
        else
        {
            Animator.SetBool("Camina para atras", false);
        }

        if(Input.GetKey(KeyCode.W))
        {
            Animator.SetBool("Camina de frente", true);
        }
        else
        {
            Animator.SetBool("Camina de frente", false);
        }


    }
}
