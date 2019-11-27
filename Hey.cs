using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hey : MonoBehaviour {

    public Score LOL;
   
	void Start () {
        LOL = GameObject.FindWithTag("ll").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Text>().text = LOL.score1.ToString();
	}
}
