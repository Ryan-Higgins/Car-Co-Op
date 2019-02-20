using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float v;
    private float h;

    public int speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        /*v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");*/
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Player1"))
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * speed * Time.deltaTime;
        }else if (gameObject.CompareTag("Player2"))
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"), 0);
            transform.position += move * speed * Time.deltaTime;
        }
    }
}
