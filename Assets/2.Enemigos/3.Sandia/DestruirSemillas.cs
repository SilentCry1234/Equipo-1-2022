using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSemillas : MonoBehaviour
{
    public GameObject Espada;
    public float CuentaRegDestruir;
    private void Start()
    {
        
    }

    private void Update()
    {
        Destruccion();

    }

    public void Destruccion()
    {
        Destroy(this.gameObject, CuentaRegDestruir);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<MovimientoPersonaje>())
        {
            Destroy(this.gameObject);

        }
    }
}
