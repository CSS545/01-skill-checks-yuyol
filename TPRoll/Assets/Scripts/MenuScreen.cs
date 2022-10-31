using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScreen : MonoBehaviour
{
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

}
