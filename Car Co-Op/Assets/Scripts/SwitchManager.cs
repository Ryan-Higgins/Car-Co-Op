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

    private int brakingForce = 4;
    private int speed = 10;
    
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
            print("I'm driving");
            shipRB.AddForce(Vector3.right * speed);
        }
        
        if (isStopping)
        {
            print("I'm Stopping");
            shipRB.drag = brakingForce;
        }

        if (!isStopping)
        {
            shipRB.drag = 1;
        }

        if (doubleSpeed)
        {
            print("SO FAST");
            speed = 20;
        }else if(doubleStop)
        {
            print("SO SLOW");
            brakingForce = 8;
        }
        
    }

}
