using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneManager : MonoBehaviour
{
    public StatsPanel statsPanel;
    public ErasePanel erasePanel;
    // Start is called before the first frame update
    // public Text text;
    void Start()
    {
        
        //open count
        int countTmp = PlayerPrefs.GetInt("openCount",0);
        PlayerPrefs.SetInt("openCount",++countTmp);
        Debug.Log("OpenOptionCount" + countTmp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void test(){
        SceneManager.LoadScene("MenuScene");
    }
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ShowStats()
    {
        statsPanel.gameObject.SetActive(true);
    }
    public void EraseSetting()
    {
        erasePanel.gameObject.SetActive(true);
    }
}
