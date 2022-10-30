using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public AdFullScreen adScreen;
    private int deathCounter;
    //control the contineous gameplays per fullscreen ad break
    public int MinGameBeforeAd = 2;
    //awake called before starts

    public Timer timer;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    // Called when ever enable as active
    private void OnEnable()
    {
        timer.TimerActive(false);

        Time.timeScale = 10;
        deathCounter++;
    }

    private void OnDisable()
    {
        timer.TimerActive(true);

        Time.timeScale = 1;
    }


    //reload the scene/level
    public void RestartGame()
    {
        checkAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        checkAd();
        SceneManager.LoadScene("MenuScene");
    }

    private void checkAd() {
        int CurPoo = PlayerPrefs.GetInt("CurrentPoo", 0);
        int HighScore = PlayerPrefs.GetInt("highScore", 0);
        if (CurPoo > HighScore) {
            PlayerPrefs.SetInt("highScore", CurPoo);
        }
        if (deathCounter > MinGameBeforeAd)
        {
            adScreen.gameObject.SetActive(true);
            deathCounter = 0;
        }
    }


}
