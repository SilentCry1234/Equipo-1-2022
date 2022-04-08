using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionEnemigo : MonoBehaviour
{
    public float CuentaRegDestruir;
    [SerializeField] private AudioSource muerteFruta; 

    private void Update()
    {
        Destruccion();
    }

    public void Destruccion()
    {
        muerteFruta.Play(); 
        Destroy(this.gameObject, CuentaRegDestruir);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorPersonaje>())
        {
            muerteFruta.Play();
            Destroy(this.gameObject);
        }
    }
}
