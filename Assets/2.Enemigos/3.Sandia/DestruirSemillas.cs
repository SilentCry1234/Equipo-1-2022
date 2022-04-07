using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSemillas : MonoBehaviour
{
    //public GameObject Espada;
    public float CuentaRegDestruir;

    private void Update()
    {
        Destruccion();

    }

    public void Destruccion()
    {
        Destroy(this.gameObject, CuentaRegDestruir);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Chocando");
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
    }
}
