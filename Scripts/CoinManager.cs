using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{

    public int coinCount;
    public int highScore;
    public static string valueToKeep;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI highText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore",0);
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: "+coinCount.ToString();
        StaticData.valueToKeep = coinCount;

        if(highScore<coinCount){

            PlayerPrefs.SetInt("highscore", coinCount);
        }
        highText.text = "Highscore: "+highScore.ToString();
        
    }
}
