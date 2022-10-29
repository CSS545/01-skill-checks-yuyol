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
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    // Called when ever enable as active
    private void OnEnable()
    {
        Time.timeScale = 0;
        deathCounter++;
    }

    private void OnDisable()
    {
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
        if (deathCounter > MinGameBeforeAd)
        {
            adScreen.gameObject.SetActive(true);
            deathCounter = 0;
        }
    }


}
