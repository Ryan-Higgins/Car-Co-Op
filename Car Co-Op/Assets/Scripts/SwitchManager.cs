using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public static bool isGoing;
    public static bool isStopping;

    public static bool doubleSpeed;
    public static bool doubleStop;

    public GameObject ship;
    private Rigidbody shipRB;
    public static bool left, right; 
    private int brakingForce = 4;
    public float speed = 3f, maxSpeed = 40f, rotationSpeed = 45f;
    float drageForce = 0.9f; 
    
    // Start is called before the first frame update
    void Start()
    {
        shipRB = ship.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

         
        if (isGoing)
        {
            // print("I'm driving");
            //ship.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Vector3 direction = ship.transform.TransformDirection(Vector3.forward);

            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
            }
        }else{
           // shipRB.velocity = (shipRB.velocity *  drageForce);

        }
        
        if (isStopping)
        {
            //print("I'm Stopping");
            shipRB.drag = brakingForce;
        }

        if (!isStopping)
        {
            //shipRB.drag = 1;
        }

        if (doubleSpeed)
        {
            //print("SO FAST");
            //speed = 20;
            Vector3 direction = ship.transform.TransformDirection(Vector3.forward);
            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
            }
        }
        else if(doubleStop)
        {
            //print("SO SLOW");
            brakingForce = 8;
        }
        if (left)
        {
            ship.transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime); 


        }

        if(right){

            ship.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        } 


        }

}
