using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private int speed;
    private Rigidbody player;
    [SerializeField] private float Up;
    [SerializeField] float torque;
 
    void Start()
    {
        player = GetComponent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        move();
        moveUp();
    }


    public void move()
    {
        float turn = Input.GetAxis("Horizontal") * torque * Time.deltaTime;
        float turn2 = Input.GetAxis("Vertical") * torque * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(turn);

            player.AddTorque(transform.right * turn);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log(turn);
            player.AddTorque(transform.right * turn);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log(turn);

            player.AddTorque(transform.right * turn2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log(turn);
            player.AddTorque(transform.right * turn2);
        }
    }

  

    public void moveUp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // player.transform.up(0f, Up, 0f);
        }
    }
}
