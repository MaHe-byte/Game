using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverManager : MonoBehaviour
{

    public int coinCount;
    public int highScore;
    public static int valueToKeep;
    public CoinManager cm;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI highText;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore",0);
        AudioManager.Instance.PlaySFX("Death");
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: "+StaticData.valueToKeep.ToString();
        valueToKeep = coinCount;

        highText.text = "Highscore: "+highScore.ToString();
        
    }
}
