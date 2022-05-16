using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScrip : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
              
            Debug.Log(" rock lost");
    }
}
