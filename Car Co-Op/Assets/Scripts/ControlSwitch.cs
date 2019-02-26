using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            PlayerDetector.controlsSet = true;
        }
    }

    void OnTriggerExit(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            PlayerDetector.controlsSet = false;
        }
    }
}
