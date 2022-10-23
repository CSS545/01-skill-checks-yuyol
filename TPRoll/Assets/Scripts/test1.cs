using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {
        string name = "test";
        // save prefs
        PlayerPrefs.SetString("Name",name);
        // get prefs
        string newName = PlayerPrefs.GetString("Name","DefaultValue");
        Debug.Log(name);
        text.text = newName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void test(){
        SceneManager.LoadScene("MenuScene");
    }
}
