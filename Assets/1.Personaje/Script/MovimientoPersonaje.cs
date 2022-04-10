using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [Header("Velocidad")]
    [Space]
    private float Velocidad = 7;
    public bool enmermelada;

    //Direcciones 
    private float Vertical;
    private float Horizontal;
    private Vector2 moveInput; 

    //Componentes
    private Rigidbody2D rg2D;
    private Animator Animator;

    void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        movimiento();
        animaciones();
        Reducirvelocidad();
    }
    private void movimiento()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(Horizontal, Vertical).normalized;

        //rg2D.velocity = new Vector2(Horizontal * Velocidad, Vertical * Velocidad).normalized;
        rg2D.MovePosition(rg2D.position + moveInput * Velocidad * Time.fixedDeltaTime); 
    }

    private void animaciones()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Animator.SetBool("Camina para atras", true); 
        }
        else
        {
            Animator.SetBool("Camina para atras", false);
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Animator.SetBool("Camina de frente", true);
        }
        else
        {
            Animator.SetBool("Camina de frente", false);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Animator.SetBool("Camina izquierda", true);
        }
        else
        {
            Animator.SetBool("Camina izquierda", false);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Animator.SetBool("Camina derecha", true);
        }
        else
        {
            Animator.SetBool("Camina derecha", false);
        }
    }
    public void Reducirvelocidad()
    {
        if (enmermelada == true)
        {
            Velocidad = 2f;
        }

        if (enmermelada == false)
        {
            Velocidad = 7f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermelada"))
        {
            enmermelada = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermelada"))
        {
            enmermelada = false;
        }
    }
}
