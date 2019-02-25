using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public static bool isGoing;
    public static bool isStopping;

    public static bool doubleSpeed;
    public static bool doubleStop;
    public static bool doubleLeft;
    public static bool doubleRight;
    public static bool doubleHorn;

    public GameObject ship;
    private Rigidbody shipRB;
    public static bool left, right;
    private bool horn;
    private int brakingForce = 1;
    public float speed = 20f, maxSpeed = 40f, rotationSpeed = 45f;
    float drageForce = 0.9f; 
    
    // Start is called before the first frame update
    void Start()
    {
        shipRB = ship.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print(doubleRight);
        //print("I am going " + shipRB.velocity.magnitude);
        if (isGoing)
        {
            // print("I'm driving");
            //ship.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Vector3 direction = ship.transform.TransformDirection(Vector3.forward);

            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
                print("Doing");
            }
        }
        else
        {
            // shipRB.velocity = (shipRB.velocity *  dragForce);

        }

        if (isStopping)
        {
            //print("I'm Stopping");
            shipRB.drag = brakingForce;
        }

        if (!isStopping && shipRB.drag > 0)
        {
            shipRB.drag -= 0.5f;
        }

        if (doubleSpeed)
        {
            print("SO FAST");
            speed = 30;
            /*Vector3 direction = ship.transform.TransformDirection(Vector3.forward);
            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
            }*/
        }
        else if (!doubleSpeed)
        {
            speed = 20;
        }
        if (doubleStop)
        {
            //print("SO SLOW");
            brakingForce = 3;
        }else if (!doubleStop)
        {
            brakingForce = 1;
        }
        if (doubleLeft)
        {
            //print("LEFT");
            rotationSpeed = 60f;
        } 
        if (doubleRight)
        {
           // print("RIGHT");
            rotationSpeed = 60f;
        }

        if (!doubleRight && !doubleLeft)
        {
            rotationSpeed = 45f;
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
