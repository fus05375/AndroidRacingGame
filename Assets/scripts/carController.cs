using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

    public float carSpeed;
    float xMaxPos = 2.0f;
    float yMaxPos = 3.5f;

    Vector3 position;

	// Use this for initialization
	void Start () {
        position = transform.position;
	}

    // Update is called once per frame
    void Update()
    {

        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime; // moving horizontal
        position.x = Mathf.Clamp(position.x, -xMaxPos, xMaxPos); // restricting car not to go beyond map layer
        position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
        position.y = Mathf.Clamp(position.y, -yMaxPos, yMaxPos);


        transform.position = position;


    }
}
