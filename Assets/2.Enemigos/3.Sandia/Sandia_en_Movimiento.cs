using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandia_en_Movimiento : MonoBehaviour
{
    public float velocidadenemiga;
    private float parado = 0f;
    public float limite;
    private float controlVel;
    //public float VelRotar = 0.5f;
    // Variable para guardar al jugador
    [SerializeField] Transform Personaje_principal = null;
    bool activarparado = false;

    void Start()
    {

        Personaje_principal = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {

        if (Personaje_principal == null)
        {
            return;
        }

        float dist = Vector3.Distance(Personaje_principal.transform.position, transform.position);

        float fixedSpeed = controlVel * Time.deltaTime;

        //Quaternion rotation = Quaternion.LookRotation(Personaje_principal.transform.position - transform.position, transform.TransformDirection(Vector3.up * VelRotar) * Time.deltaTime);
        //transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
        transform.position = Vector3.MoveTowards(transform.position, Personaje_principal.transform.position, fixedSpeed);
        if (dist <= limite)
        {
            activarparado = true;
           // Vector3 UbicacionTarget = Personaje_principal.position - transform.position;
           // Vector3.RotateTowards(transform.forward, UbicacionTarget, fixedSpeed, 0.0f);
        }
        else
        {
            //if (dist > limite)
            //{
            activarparado = false;
            //}
            //else 
            //{ 
            //    if(dist < limite)
            //    {
            //        Vector3 UbicacionTarget = Personaje_principal.position - transform.position;
            //        Vector3.RotateTowards(transform.forward, UbicacionTarget, fixedSpeed, 0.0f);
            //    }
            //}
        }
        Parado();
        Avanzar();
    }
    public void Parado()
    {
        if (activarparado == true)
        {
            controlVel = parado;
        }
    }
    public void Avanzar()
    {
        if (activarparado == false)
        {
            controlVel = velocidadenemiga;
        }
    }
}
