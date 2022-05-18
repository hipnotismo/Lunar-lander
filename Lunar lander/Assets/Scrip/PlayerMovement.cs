using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    private Rigidbody player;
    [SerializeField] private float MaxUp;
    [SerializeField] private float Up;
    [SerializeField] float torque;
    [SerializeField] private float fuel;
    [SerializeField] private AudioSource propulsion;
    private float pVector;
    private bool done;

    private bool useSound = true;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        done = false;
        propulsion.Play();
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
                //Restart();
            }          
        }

       
    }


    public void move()
    {
        float turn = Input.GetAxis("Horizontal") * torque * Time.deltaTime;
        float turn2 = Input.GetAxis("Vertical") * torque * Time.deltaTime;
        pVector = transform.eulerAngles.x;
    
        if (Input.GetKey(KeyCode.A ) )
        {
            
                player.AddTorque(transform.right * turn);
            
            
        }
        if (Input.GetKey(KeyCode.I))
        {
            player.angularVelocity = new Vector3(0, 0, 0);
        }
           
            if (Input.GetKey(KeyCode.D))
        {
            player.AddTorque(transform.right * turn);
        }

     
    }

  

    public void moveUp()
    {
        if (Input.GetButton("Jump"))
        {
            if (fuel != 0)
            {
                player.AddForce(transform.up * Up);
                fuel -= 1 * Time.deltaTime;
                Debug.Log(fuel);
                if (useSound)
                {
                    //propulsion.UnPause();

                }
            }

        }
        else
        {
            //propulsion.Pause();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        done = true;
        player.isKinematic = true;
        Debug.Log("aaaaa");
        useSound = false;
        GameManager.inst.addPoints(fuel * 2);

    }

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
