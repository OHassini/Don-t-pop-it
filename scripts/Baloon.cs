using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Baloon : MonoBehaviour {
    public GameObject baloon;
    public float speed= 3f;
    Rigidbody2D rb;
    public float x;
    public float y;
    Vector2 bp;
    
    public float nextCpy = 0.1f;
    public float time = 1f;
	// Use this for initialization
	void Start ()
    {
        float x = Random.Range(-2.58f, 2.58f);
        float y = Random.Range(8f, 50f);
        bp = new Vector2(x, y);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed ;
        StartCoroutine("Bat");
        //Invoke("CreateBaloons", time);

        
        

    }
	
	// Update is called once per frame
	void Update () {

        
    }
   void  CreateBaloons()
    {
         
       
           
        Instantiate(baloon, bp, Quaternion.identity);
        












    }
    IEnumerator Bat()
    {
       while (time > 0.1)
        {
            yield return new WaitForSeconds(time);
            CreateBaloons();
            time = time - nextCpy;
        }
        
       if (time < 0.1)
        {
            time = 0.2f;
        }

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ll")
        {
            Destroy(gameObject);

            

        }
        if(collision.gameObject.tag == "loose")
        {
            this.GetComponent<Collider2D>().enabled = false;
            this.GetComponent<Animator>().Play("popped baloon");
            this.GetComponent<AudioSource>().Play();
            if(PlayerPrefs.GetInt("Reverse") == 0) { Handheld.Vibrate(); }
            
            
            speed = 0;
            if (PlayerPrefs.GetInt("Reverse") == 0)
            {
                Invoke("Wait", 0.7f);
            }
            


        }
    }
    public void Wait()
    {
       
        SceneManager.LoadScene("Lose Scene");
    }


}
