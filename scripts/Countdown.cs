using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

    public float cont;
    public int num;
    public TextMeshProUGUI contdo;
    public BaloonNewMod ball;
    private void Start()
    {
        cont = 30;
        ball = GameObject.FindWithTag("loose").GetComponent<BaloonNewMod>();
    }
    public void FixedUpdate()
    {
        cont -= Time.deltaTime;
       num =  Mathf.RoundToInt(cont);
        if (contdo != null)
        {
            contdo.text = num.ToString();
        }
        if (num < 0)
        {
            num = 0;
        }
        if(num == 0)
        {
            if (ball.scorego > PlayerPrefs.GetInt("High Score new", 0))
                PlayerPrefs.SetInt("High Score new", ball.scorego);
            SceneManager.LoadScene("Lose Scene 1");
        }

        
    }
}
