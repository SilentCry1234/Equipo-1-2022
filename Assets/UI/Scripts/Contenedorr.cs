using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contenedorr : MonoBehaviour
{
    public GameObject[] corazones;
    public Queue<GameObject> colacorazones = new Queue<GameObject>();
    public static Contenedorr contenedores;
    void Start()
    {
        contenedores = this;
        foreach (GameObject g in corazones)
        {
            colacorazones.Enqueue(g);
            g.gameObject.SetActive(true);
        }
    }

    public void ReducirVida()
    {
        GameObject g = colacorazones.Dequeue();
        g.gameObject.SetActive(false);
        colacorazones.Enqueue(g);
    }
}
