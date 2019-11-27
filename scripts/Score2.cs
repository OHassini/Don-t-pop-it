using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour {


    public int score2;
    
    public Text Scoretext;
    



    public BaloonNewMod ball;
    private static Score2 instance;
    private void Start()
    {

       
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        ball = GameObject.FindWithTag("loose").GetComponent<BaloonNewMod>();
    }
    private void Update()
    {
        
        ball = GameObject.FindWithTag("loose").GetComponent<BaloonNewMod>();

        if (ball != null)
        {
            score2 = ball.scorego;
            
        }


       
    }
    
}
