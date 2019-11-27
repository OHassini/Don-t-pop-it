using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public int score1;
    public Text Scoretext;
   private GameObject other;



    public BaloonNewMod ball;
    private static Score instance;
    private void Start()
    {
        Scoretext = GameObject.FindWithTag("score").GetComponent<Text>();

        score1 = 0;

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        ball = GameObject.FindWithTag("loose").GetComponent<BaloonNewMod>();
    }
    private void Update()
    {
        other = GameObject.FindWithTag("test");
        other.GetComponent<AudioSource>().mute = true;
        if (GameObject.FindWithTag("score").GetComponent<Text>() != null )
        {
            Scoretext = GameObject.FindWithTag("score").GetComponent<Text>();
        }

        




        if (score1 > 22222)
        {
            Scoretext.fontSize = 90;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        score1++;
        if (Scoretext != null)
        {
            Scoretext.text = score1.ToString();
            Debug.Log(score1.ToString());
        }
             


    }



}
