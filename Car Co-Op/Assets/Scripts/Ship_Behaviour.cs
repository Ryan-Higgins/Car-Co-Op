using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Behaviour : MonoBehaviour
{
    public  TrailRenderer[] trails;
    public GameObject[] parts;
    public Camera cam; 
    void Start()
    {
        //anim = GetComponent<Animator>(); 
        //trails = GetComponentsInChildren<TrailRenderer>(); 
    }

    public Animator anim;
    bool boost = false;
    public float boosterLimit = 10; 
    void Update()
    {

        //Debug.Log(Time.deltaTime);
        float vol = GetComponent<Rigidbody>().velocity.magnitude;
        Debug.Log(vol);
        if(vol >= boosterLimit){
            anim.SetBool("Boost", true);
            boost = true; 
        } else{
            anim.SetBool("Boost", false);
            boost = false;
        } 
        Boosters();

    }

    void Boosters(){
        for (int i = 0; i < trails.Length; i++)
        {
            trails[i].enabled = boost;
            parts[i].SetActive(boost);
        }

    }

    private void OnCollisionEnter(Collision other){
        
        if(other.gameObject.tag != "Ground"){

            cam.GetComponent<ScreenShake>().ShakeScreen(); ;
        } 
        
    }
}
