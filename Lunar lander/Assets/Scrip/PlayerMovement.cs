using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody player;
    [SerializeField] private float Up;
    [SerializeField] float torque;
    private float pVector;
    private bool done;
 
    void Start()
    {
        player = GetComponent<Rigidbody>();
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        moveUp();
        if (Input.GetButton("Submit"))
        {
            if (done == true)
            {
                done = false;
                Debug.Log("restart");
                Restart();
            }          
        }

       
    }


    public void move()
    {
        float turn = Input.GetAxis("Horizontal") * torque * Time.deltaTime;
        float turn2 = Input.GetAxis("Vertical") * torque * Time.deltaTime;
        pVector = transform.eulerAngles.x;
    //  Debug.Log(pVector);

        // turn = Mathf.Clamp(turn, -90, 90);

        if (Input.GetKey(KeyCode.A ) )
        {
            //if (pVector > 345 && pVector <= 360 && pVector )
            //{
                //Debug.Log("if");
               // Debug.Log(pVector);
                player.AddTorque(transform.right * turn);
            
            //else
            //{
            //    //player.freezeRotation = true;
            //    Debug.Log("else");

            //    player.angularVelocity = new Vector3(0,0,0);
            //}
        }
        if (Input.GetKey(KeyCode.I))
        {
          //  Debug.Log("i");
            player.angularVelocity = new Vector3(0, 0, 0);
        }
            //        else
            //        {
            ////            Debug.Log(turn);
            //            //    player.AddTorque(transform.right * 0);
            //           /// player.freezeRotation = true;

            //        }
            if (Input.GetKey(KeyCode.D))
        {
          //  Debug.Log(turn);
            player.AddTorque(transform.right * turn);
        }

        // de momento hacelo en 2d
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log(turn2);

        //    player.AddTorque(transform.forward * turn2);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log(turn2);
        //    player.AddTorque(transform.forward * turn2);
        //}
    }

  

    public void moveUp()
    {
        if (Input.GetButton("Jump"))
        {
            player.AddForce(transform.up * Up );

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        done = true;
        player.isKinematic = true;
        Debug.Log("aaaaa");
    }

    public void Restart()
    {
        SceneManager.LoadScene("More testing");
    }
}
