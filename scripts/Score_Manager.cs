using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using TMPro;
public class Score_Manager : MonoBehaviour {
    private Score score;
    
   
    public Text High_Score;
    public Text Last_Score;
    public int Money;
    public TextMeshProUGUI MoneyAmount;
    
    public TextMeshProUGUI moneyText;
    private void Update()
    {
       
       
    }

    void Start () {
       
            High_Score.text = PlayerPrefs.GetInt("High Score", 0).ToString();
        Last_Score.text = 0.ToString();

        
        
       
        GameObject coreObj = GameObject.FindWithTag("ll");
        




        if (coreObj != null)
        {
            score = coreObj.GetComponent<Score>();
            Debug.Log(score.score1.ToString());

            Last_Score.text = score.score1.ToString();
                Money = PlayerPrefs.GetInt("Money", 0) +score.score1;
                moneyText.text = score.score1.ToString();
            
            
            PlayerPrefs.SetInt("Money", Money);
            MoneyAmount.text = PlayerPrefs.GetInt("Money", 0).ToString();
            

        }
       







        if (score.score1 > 1000 )
        {
            Last_Score.fontSize = 93;
        }
        if (PlayerPrefs.GetInt("High Score", 0) > 1000)
        {
            High_Score.fontSize = 93;
        }
        if(score.score1 > PlayerPrefs.GetInt("High Score", 0))
        {
            High_Score.text = score.score1.ToString();

        }

       
    }
    

}
