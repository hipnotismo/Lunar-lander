using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{
    public Transform target;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 targetDir = target.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        Debug.Log(angle);
        if (angle < 131 | angle > 132.48)
        {
            Debug.Log("lost");

        }
        //Debug.Log("Contacto");
    }
}
