using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chouka : MonoBehaviour
{

    public Mouvement mouv;
    public Score score;
    public bool loose;
   
    // Use this for initialization
    void Start()
    {

        mouv = GameObject.FindWithTag("loose").GetComponent<Mouvement>();
        score = GameObject.FindWithTag("ll").GetComponent<Score>();
        loose = false;
    }

    // Update is called once per frame
    void Update()
    {
            
        
           /* mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);*/
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "balloon")
        {
            

            if (PlayerPrefs.GetInt("Reverse") == 0)
            {
                if (score.score1 > PlayerPrefs.GetInt("High Score", 0))
                    PlayerPrefs.SetInt("High Score", score.score1);
            }
          

            loose = true;

        }
        else
        {
            loose = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        gameObject.SetActive(false);
       
    }


}