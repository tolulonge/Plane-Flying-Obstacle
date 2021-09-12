using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    private float turnSpeed = 20.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
 
 

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
       // transform.Translate(Vector3.forward * Time.deltaTime * 20 * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Moves the car forward based on vertical input
        if (Input.GetKey(KeyCode.Space))
        {
           
            playerRb.AddForce(Vector3.up * 25, ForceMode.Acceleration);

        }
        if (Input.GetKey(KeyCode.P))
        {

            playerRb.AddForce(Vector3.down * 15, ForceMode.Acceleration);

        }
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 20);
        }

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * forwardInput);
        //if (transform.position.y > backgroundHeight && playerRb.velocity.y > 0)
        //{
        //    floatForce = 4;
        //    transform.position = new Vector3(transform.position.x, backgroundHeight, transform.position.z);
        //    playerRb.AddForce(Vector3.down * floatForce, ForceMode.Impulse);
        //    playerRb.velocity = Vector3.up * -floatForce / 4;
        //}
    }

    //

    //    // Rotates the car based on horizontal input
    //    

    //void FixedUpdate()
    //{
    //    // get the user's vertical input
    //    verticalInput = Input.GetAxis("Vertical");

    //    // move the plane forward at a constant rate
    //    transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
    //}
        
  
}
