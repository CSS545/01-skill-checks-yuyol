using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScreen : MonoBehaviour
{
    private void OnEnable()
    {
        if (PlayerPrefs.GetInt("NightClub", 0) != 0)
        {
            PlayerPrefs.SetInt("NightClub", 0);
        }
    }
    public void PlayGame(){
        SceneManager.LoadScene("GameScene");
    }

    public void DisplayOptions(){
        SceneManager.LoadScene("optionScene");
    }

    public void QuitGame(){
        
    }
    public void DisplayGoogleStore()
    {
        SceneManager.LoadScene("googleScene");
    }
    public void SetNightClub(bool isNClub)
    {
        PlayerPrefs.SetInt("NightClub", (isNClub ? 1 : 0));
    }
}
