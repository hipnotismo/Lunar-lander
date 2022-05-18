using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataform : MonoBehaviour
{
    public Transform target;
    [SerializeField] private float MinAngle;
    [SerializeField] private float MaxAngle;

    [SerializeField] private float MinPoints;
    [SerializeField] private float MaxPoints;

    private void Start()
    {

    }

    private void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 targetDir = target.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        Debug.Log(angle);
        if (angle < MinAngle | angle > MaxAngle)
        {
            Debug.Log("lost");
            // manager.SendMessage("addPoints", 5.0);
            GameManager.inst.addPoints(MinPoints);
            GameManager.inst.Lose();
        }
        else
        {
            Debug.Log("win");
            GameManager.inst.addPoints(MaxPoints);
            GameManager.inst.Win();

            //  manager.SendMessage("addPoints", 10.0);

        }
        //Debug.Log("Contacto");
    }
}
