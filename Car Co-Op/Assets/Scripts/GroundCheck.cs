using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit,1f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down), Color.red);
            print("Jump");
            SwitchManager.onGround = true;
        } else
        {
            SwitchManager.onGround = false;
        }
    }
}
