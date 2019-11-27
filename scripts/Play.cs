using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    public Button start;
    public Buttons ReversState;
    
	// Use this for initialization
	void Start () {
        start = GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

  public void TaskOnClick()
    {if(PlayerPrefs.GetInt("Reverse") == 0)
        SceneManager.LoadScene("I willl choose the name later");
    else if(PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }

}
