using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {
    private Score Score;
    public Text scoreText;

    
    public Chouka chouka;
	void Start () {
		Score = GameObject.FindWithTag("ll").GetComponent<Score>();
        chouka = GameObject.FindWithTag("loose").GetComponent<Chouka>();
        if(chouka.loose == false)
        {
            Score.score1 = 0;
        }
        
    }
	
	// Update is called once per frame
	void Update () {
       
        scoreText.text = Score.score1.ToString();
	}
}
