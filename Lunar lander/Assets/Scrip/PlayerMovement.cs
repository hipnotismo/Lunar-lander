using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody player;

    void Start()
    {
        player = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("FUCK");
            player.AddTorque(5, 0, 10);
        }
        if (Input.GetKey(KeyCode.D))
        {

        }
        if (Input.GetKey(KeyCode.W))
        {
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            
        }
    }
}
