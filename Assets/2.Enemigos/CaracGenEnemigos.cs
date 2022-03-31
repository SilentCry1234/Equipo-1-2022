using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracGenEnemigos : MonoBehaviour
{
    [Header("Caracteristicas")]
    [Space]
    public string nombre;
    public float vida;
    public float velocity;

    public static CaracGenEnemigos instance;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
            instance = this;
        }
    }
}