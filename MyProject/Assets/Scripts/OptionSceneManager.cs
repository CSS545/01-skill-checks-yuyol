using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    // public Text text;
    void Start()
    {
        

        //open count
        int countTmp = PlayerPrefs.GetInt("openCount",0);
        PlayerPrefs.SetInt("openCount",++countTmp);
        Debug.Log(countTmp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void test(){
        SceneManager.LoadScene("MenuScene");
    }
}
