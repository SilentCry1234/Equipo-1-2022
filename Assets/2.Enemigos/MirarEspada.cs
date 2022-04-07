using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarEspada : MonoBehaviour
{
    public float VelRotar;
    ControladorPersonaje Personaje_principal = null;

    private void Start()
    {
        Personaje_principal = FindObjectOfType<ControladorPersonaje>();
    }
    private void Update()
    {
        if (Personaje_principal == null)
        {
            return;
        }
        //Quaternion rotation = Quaternion.LookRotation(Personaje_principal.transform.position - transform.position, transform.TransformDirection(Vector3.up * VelRotar) * Time.deltaTime);
        //transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
        Vector3 myLocation = transform.position;
        Vector3 targetLocation = Personaje_principal.transform.position;
        targetLocation.z = myLocation.z; // ensure there is no 3D rotation by aligning Z position

        // vector from this object towards the target location
        Vector3 vectorToTarget = targetLocation - myLocation;
        // rotate that vector by 0 degrees around the Z axis
        Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 0) * vectorToTarget;

        // get the rotation that points the Z axis forward, and the Y axis 0 degrees away from the target
        // (resulting in the X axis facing the target)
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);

        // changed this from a lerp to a RotateTowards because you were supplying a "speed" not an interpolation value
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, VelRotar * Time.deltaTime);
        //transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
    }
}