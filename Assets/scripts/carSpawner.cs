using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour {


    public GameObject[] cars;
    int carNo;
    float maxPos = 2.2f;

    float timer;
    public float delayTimer = 2f;
	// Use this for initialization
	void Start () {
        timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            //putting enemy car randomly
            Vector3 carPos = new Vector3(Random.Range(-maxPos, maxPos), transform.position.y, transform.position.z);
            carNo = Random.Range(0, 4);
            //initation of object
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
        
    }
}
