using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

	Vector3 startingPos;
    public Transform resetPoint; 
    [Range(0,20)]
    public float speed = 5f, duration = 0.5f, mag = 20f; 

	void Start () {

		//startingPos = transform.position; 

	}
	
    public void ShakeScreen(){
        StopAllCoroutines();
        StartCoroutine(Shake(speed, duration, mag));
    }
    public void ShakeScreen(float x, float y , float z){
        StopAllCoroutines();
        StartCoroutine(Shake(speed * x, duration * y, mag * z));
    }
    void ResetScreen(){

        transform.position  = Vector3.Lerp(transform.position, resetPoint.transform.position, Time.deltaTime * 4f);

    }

    IEnumerator Shake(float _speed, float _duration, float _mag){

        

        while(_duration > 0f){

            float alpha = Random.Range(-1000, 1000) + (_speed * _duration);
            float x = Mathf.PerlinNoise(alpha, 0.0f) * 2.0f - 1.0f;
            float y = Mathf.PerlinNoise( 0.0f,alpha) * 2.0f - 1.0f;

            x *= _mag;
            y *= _mag; 
            transform.position = startingPos + new Vector3(x, y, 0);
            _duration -= Time.deltaTime; 
            yield return new WaitForSeconds(0f);
        }
        ResetScreen();
    }
}
