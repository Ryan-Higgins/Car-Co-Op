using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holo_Road_Effect : MonoBehaviour
{
    Renderer rend;  
    void Start()
    {
        rend = GetComponent<Renderer> ();
        
    }

    public float offsetSpeed = 5f;
    Vector2 textureOffset;  
    void Update()
    {
        textureOffset.x += offsetSpeed * Time.deltaTime; 

        rend.material.SetTextureOffset("_MainTex", textureOffset); 
        
    }
}
