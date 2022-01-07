using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float jumpY;
    public float jumpForce;

    private Vector3 jumpVector;
    private Rigidbody rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        jumpVector = new Vector3(0f, jumpY, 0f);

    }

    // Update is called once per frame
    private void FixedUpdate()
    { 
        rigidbody.AddRelativeForce(Vector3.forward * speed);
        
        //Movement Keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           rigidbody.AddRelativeForce(Vector3.forward * speed);
           rigidbody.AddTorque(-Vector3.up * turnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           rigidbody.AddRelativeForce(Vector3.forward * speed);
           rigidbody.AddTorque(Vector3.up * turnSpeed * 10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddRelativeForce(-Vector3.forward * speed);
        }
     
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(jumpVector * jumpForce, ForceMode.Impulse);
        }
    }

}
