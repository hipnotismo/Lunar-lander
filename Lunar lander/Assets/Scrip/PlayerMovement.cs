using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float leftAngle;
    [SerializeField] private float rightAngle;
    [SerializeField] private int speed;
    [SerializeField] private Rigidbody player;
    [SerializeField] private float Up;

    private float pieceSize;
    bool movingClockwise;

    void Start()
    {
        movingClockwise = true;

    }

    // Update is called once per frame
    void Update()
    {
        move();
        speedIncrease();
        moveUp();
    }

    public void ChangeMoveDir()
    {


        if (transform.rotation.z > rightAngle)
        {
            movingClockwise = false;
        }

        if (transform.rotation.z < leftAngle)
        {
            movingClockwise = true;
        }

    }

    public void move()
    {
        ChangeMoveDir();

        if (Input.GetKey(KeyCode.A))
        {
            // transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
            player.AddTorque(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.AddTorque(0, 0, -speed);
            //transform.Rotate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
    }

    public void speedIncrease()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 10;
        }
    }

    public void moveUp()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.Translate(0f, Up, 0f);
        }
    }
}
