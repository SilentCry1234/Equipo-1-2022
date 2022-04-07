using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararSemillas : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject semillasobject;
    public GameObject spawn;
    ControladorPersonaje Espada;
    [Space]
    [Header("Distancia")]
    [SerializeField] float distancia_deAct;
    [Space]
    [Header("Demoras entre disparos")]
    public float delaySpawn = 5f;
    public float delayRonda = 15f;
    private float proxRonda = 0.0f;
    private float proximoSpawn = 0.0f;

    private void Start()
    {
        Espada = FindObjectOfType<ControladorPersonaje>(); 
    }


    void Update()
    {

        float dist = Vector3.Distance(Espada.transform.position, transform.position);
        if (dist <= distancia_deAct && Time.time > proximoSpawn && Time.time >= 2.5f)
        {
            SpawnearSeguido();
        }

        else
        {
            if (Time.time >= proxRonda)
            {
                SpawnearRonda();
            }
        }

    }
    public void SpawnearSeguido()
    {
        //Que la variable proxSpawn sea igual al tiempo de unity sumado al delay entre disparos
        //Asi dicha variable siempre estará por delante del tiempo, de lo contrario sin Time.time, solo funcionaria una vez
        proximoSpawn = Time.time + delaySpawn;
        //Y que los proyectiles spawneen segun la posición y rotación de su Spawn
        Instantiate(semillasobject, spawn.transform.position, spawn.transform.rotation);
    }
    public void SpawnearRonda()
    {

        proxRonda = Time.time + delayRonda;

        proximoSpawn = Time.time + delaySpawn;


    }
}
