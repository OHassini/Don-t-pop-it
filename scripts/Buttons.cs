using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Buttons : MonoBehaviour {

    public GameObject background;
    public GameObject background1;
    public GameObject pannel;
    public Toggle soundToggle;
    private Score score;
    
    private void Start()
    {

        

        if (soundToggle == null) { return; }
        if(pannel != null)
        if(pannel == null) { return; }
            else { pannel.SetActive(false); }
        
        soundToggle.isOn = Mute;

        
    }


    public void Credits()
    {
        pannel.SetActive(true);
        StartCoroutine(Wait());
        
    }
    
    public void Restart()
    {
        if (PlayerPrefs.GetInt("Reverse") == 0)
        {
           
            SceneManager.LoadScene("I willl choose the name later");
           
        }
     if(PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");


    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }
    public bool Mute
    {
       get
        {
            return PlayerPrefs.GetInt("mute") == 1;
        }
        set
        {if (GameObject.FindWithTag("ll") != null)
            {

                GameObject.FindWithTag("ll").GetComponent<AudioSource>().
                mute = value;
                PlayerPrefs.SetInt("mute", value ? 1 : 0);
               background.GetComponent<AudioSource>().
                    mute = true;
            }
            else
            {
                background.GetComponent<AudioSource>().
                    mute = value;
                PlayerPrefs.SetInt("mute", value ? 1 : 0);
            }
            if (GameObject.FindWithTag("test") != null)
            {

                GameObject.FindWithTag("test").GetComponent<AudioSource>().
                mute = value;
                PlayerPrefs.SetInt("mute", value ? 1 : 0);
                GameObject.FindWithTag("test").GetComponent<AudioSource>().
                     mute = true;
            }
            else
            {
                GameObject.FindWithTag("test").GetComponent<AudioSource>().
                    mute = value;
                PlayerPrefs.SetInt("mute", value ? 1 : 0);
            }
        }

    }
    public void ToggleValueChanged(Toggle change)
    {
        Mute = change.isOn;
    }

    IEnumerator Wait()
    {
      
        yield return new WaitForSeconds(3f);
        pannel.SetActive(false);

    }
    
    public void Shop()
    {
        SceneManager.LoadScene("test");
    }
    public void Reverse()
    {if (PlayerPrefs.GetInt("Reverse") == 0)
        {
            PlayerPrefs.SetInt("Reverse",1);
        }
        else if(PlayerPrefs.GetInt("Reverse") == 1)
        {
            PlayerPrefs.SetInt("Reverse", 0);
        }
    }



}
