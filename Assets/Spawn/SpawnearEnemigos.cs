using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnearEnemigos : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject gameEnemie;
    public GameObject spawn;
    [SerializeField] float tiempo;

    [Space]
    [Header("Demoras entre disparos")]
    public float delaySpawn = 5f;
    public float delayRonda = 15f;
    private float proxRonda = 0.0f;
    private float proximoSpawn = 0.0f;
    
    private void Update()
    {

        if (tiempo <= Time.fixedTime && Time.time > proximoSpawn)
        {
            SpawnearSeguido();
        }
        else
        {
            if (Time.time > proxRonda)
            {
                SpawnearRonda();
            }
        }

    }
    public void SpawnearSeguido()
    {
        //Que la variable proxDisparo sea igual al tiempo de unity sumado al delay entre disparos
        //Asi dicha variable siempre estará por delante del tiempo, de lo contrario sin Time.time, solo funcionaria una vez
        proximoSpawn = Time.time + delaySpawn;
        //Y que los proyectiles spawneen segun la posición y rotación de su Spawn
        Instantiate(gameEnemie, spawn.transform.position, spawn.transform.rotation);
    }
    public void SpawnearRonda()
    {

        proxRonda = Time.time + delayRonda;

        proximoSpawn = Time.time + delaySpawn;


    }
}
