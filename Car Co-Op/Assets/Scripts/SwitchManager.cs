using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    public static bool isGoing;
    public static bool isStopping;
    public static bool isJumping;

    public static bool doubleSpeed;
    public static bool doubleStop;
    public static bool doubleLeft;
    public static bool doubleRight;
    public static bool doubleHorn;
    public static bool doubleJump;

    public static bool onGround;

    public GameObject ship;
    private Rigidbody shipRB;
    public static bool left, right;
    public static bool horn;
    private int brakingForce = 4;
    public float speed = 15f, maxSpeed = 30f, rotationSpeed = 45f;
    private float startSpeed, startRot;
    private int startBreak;
    float dragForce = 0.9f; 
    
    // Start is called before the first frame update
    void Start()
    {
        shipRB = ship.GetComponent<Rigidbody>();
        startSpeed = speed;
        startBreak = brakingForce;
        startRot = rotationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = ship.transform.TransformDirection(Vector3.forward);
        //print("On Ground: " + onGround);
        if (shipRB.velocity.magnitude < maxSpeed)
        {
            shipRB.AddForce(direction * speed);
           // print("Doing");
        }
        //print(doubleRight);
        //print("I am going " + shipRB.velocity.magnitude);
        /*if (isGoing)
        {
            // print("I'm driving");
            //ship.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            /*Vector3 direction = ship.transform.TransformDirection(Vector3.forward);

            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
                print("Doing");
            }#1#
        }*/

        if (isJumping)
        {
            print("JUMPING");
            if (onGround)
            {
                shipRB.AddForce(Vector3.up * 100);
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
            speed = speed * 2;
            /*Vector3 direction = ship.transform.TransformDirection(Vector3.forward);
            if (shipRB.velocity.magnitude < maxSpeed)
            {
                shipRB.AddForce(direction * speed);
            }*/
        }
        else if (!doubleSpeed)
        {
            speed = startSpeed;
        }
        if (doubleStop)
        {
            //print("SO SLOW");
            brakingForce = brakingForce * 2;
        }else if (!doubleStop)
        {
            brakingForce = startBreak;
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
            rotationSpeed = startRot;
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
