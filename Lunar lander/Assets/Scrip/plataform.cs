using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float MinAngle;
    [SerializeField] private float MaxAngle;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Vector3 targetDir = target.position - transform.position;
            float angle = Vector3.Angle(targetDir, transform.forward);
            Debug.Log(angle);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 targetDir = target.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        Debug.Log(angle);
        if (angle < MinAngle | angle > MaxAngle)
        {
            Debug.Log("lost");

        }
        else
        {
            Debug.Log("win");
        }
        //Debug.Log("Contacto");
    }
}
