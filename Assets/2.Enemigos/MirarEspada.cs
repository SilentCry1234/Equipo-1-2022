using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarEspada : MonoBehaviour
{
    public float VelRotar = 0.5f;
    [SerializeField] GameObject Personaje_principal = null;


    private void Update()
    {
        if (Personaje_principal == null)
        {
            return;
        }
        Quaternion rotation = Quaternion.LookRotation(Personaje_principal.transform.position - transform.position, transform.TransformDirection(Vector3.up * VelRotar) * Time.deltaTime);
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
    }
}