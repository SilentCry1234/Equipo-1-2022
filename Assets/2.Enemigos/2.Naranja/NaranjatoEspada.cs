using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaranjatoEspada : MonoBehaviour
{
    public ControladorPersonaje control;
    public float velocidadenemiga;
    // Variable para guardar al jugador
    [SerializeField] Transform Personaje_principal = null;


    private void Start()
    {
        control = FindObjectOfType<ControladorPersonaje>();
        Personaje_principal = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    
    void Update()
    {
        if (control.enmantel == false)
        {

            if (Personaje_principal == null)
            {
                return;
            }

            float fixedSpeed = velocidadenemiga * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, Personaje_principal.transform.position, fixedSpeed);

            transform.up = Personaje_principal.position - transform.position;
        }
    }
}
