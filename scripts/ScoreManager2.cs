using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager2 : MonoBehaviour {

    private Score2 score;


    public Text High_Score;
    public Text Last_Score;
    public int Money;
    public TextMeshProUGUI MoneyAmount;

    public TextMeshProUGUI moneyText;
    private void Update()
    {


    }

    void Start()
    {

        High_Score.text = PlayerPrefs.GetInt("High Score new", 0).ToString();
        
       



        GameObject coreObj = GameObject.FindWithTag("test");





        if (coreObj != null)
        {
            score = coreObj.GetComponent<Score2>();
            


            Last_Score.text = score.score2.ToString();
            Money = PlayerPrefs.GetInt("Money", 0) + score.score2;
            moneyText.text = score.score2.ToString();


            PlayerPrefs.SetInt("Money", Money);
            MoneyAmount.text = PlayerPrefs.GetInt("Money", 0).ToString();


        }








       


    }
}
