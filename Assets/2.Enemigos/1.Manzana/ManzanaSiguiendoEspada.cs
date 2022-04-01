using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManzanaSiguiendoEspada : MonoBehaviour
{
    public float velocidadenemiga;
    // Variable para guardar al jugador
    [SerializeField] Transform Personaje_principal = null;
    void Start()
    {
        //recuperamos al jugador gracias al Tag

        Personaje_principal = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update() 
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