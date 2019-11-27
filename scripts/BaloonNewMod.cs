using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BaloonNewMod : MonoBehaviour
{

    public Mouvement mouv;
   
    public bool loose;
    public Text scoretext;
    public int scorego;

    // Use this for initialization
    void Start()
    {

        mouv = GameObject.FindWithTag("loose").GetComponent<Mouvement>();
        scoretext = GameObject.FindWithTag("score").GetComponent<Text>();
        loose = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("Reverse") == 1)
        { 
        scoretext.text = scorego.ToString();
        }
        /* mousePosition = Input.mousePosition;
         mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
         transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);*/

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "balloon")
        {
            

          

            loose = true;

        }
        else
        {
            loose = false;
        }

        if (collision.gameObject.tag == "balloon")
        {
            scorego++;

        }

    }
    


}