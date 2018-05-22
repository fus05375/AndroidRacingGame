﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{

    public Text scoreText;
    int score;
    bool gameOver;
    

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    void scoreUpdate() {
        if (!gameOver) {
            score += 1;
        }
        
    }

    public void gameOverActivated() {
        gameOver = true;
    }

    public void Play() {
        Application.LoadLevel("level1");
    }


    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }

    }

   

    public void Menu() {
        SceneManager.LoadScene("menuScene");
        //Application.LoadLevel("menuScene");
    }

    public void Exit() {
        Application.Quit();

    }
}
