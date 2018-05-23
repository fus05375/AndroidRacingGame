using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

    public float carSpeed;
    public float dmg = 25f;

    float xMaxPos = 2.0f;
    float yMaxPos = 3.5f;
    float live = 100f;

    Vector3 position;

    public uiManager uiManager;

    public AudioManager audioManager;

	// Use this for initialization
	void Start () {
        position = transform.position;
        audioManager.carSound.Play();
        //audioManager.startTriggerCarSound.Play();

    }

    void Awake()
    {
        //audioManager.carSound.Play();

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Car" && live <= 0)
        {
            Destroy(gameObject);
            audioManager.carSound.Pause();

            uiManager.gameOverActivated();

        }
        else {
            live = live - dmg;
        }
    }
}
