using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionEnemigo : MonoBehaviour
{
    
    public float CuentaRegDestruir;

    private void Update()
    {
        Destruccion();

    }
}

    public void Destruccion()
    {
        Destroy(this.gameObject, CuentaRegDestruir);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorPersonaje>())
        {
            Destroy(this.gameObject);

        }
    }
}
