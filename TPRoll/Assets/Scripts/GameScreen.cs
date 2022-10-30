using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour
{
    public PauseScreen pauseScreen;
    public DeathScreen deathScreen;
    public Timer timer;
    private int countTmp;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            PauseGame();
        }
    }

    public void PauseGame() {


        timer.TimerActive(false);
        //trun default offscreen on
        pauseScreen.gameObject.SetActive(true);


    }
    private void OnEnable()
    {
        timer.TimerActive(true);
    }

    public void OnPlayerDeath()
    {
        PlayerPrefs.SetInt("TotalDeath", 1 + 
                            PlayerPrefs.GetInt("TotalDeath", 0));
        Debug.Log("OnPlayDeathTotalDeath" + 
                            PlayerPrefs.GetInt("TotalDeath", 0));
        timer.TimerActive(false);
        gameObject.SetActive(false);
        deathScreen.gameObject.SetActive(true);

    }

}
