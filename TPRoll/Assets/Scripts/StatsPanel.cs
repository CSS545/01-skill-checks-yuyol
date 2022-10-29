using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;

public class StatsPanel : MonoBehaviour
{
    public Text LifeText;
    public Text PooText;
    public Text AppleText;

    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {
        int countTmp = PlayerPrefs.GetInt("TotalDeath", 0);
        if (LifeText != null)
        {
            Debug.Log("TotalDeath" + countTmp);
            LifeText.text = countTmp.ToString();
        }
        countTmp = PlayerPrefs.GetInt("highScore", 0);
        PooText.text = countTmp.ToString();
        countTmp = PlayerPrefs.GetInt("AppleEat", 0);
        AppleText.text = countTmp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
