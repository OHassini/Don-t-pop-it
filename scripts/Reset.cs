using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour {
    private Score score;

    // Use this for initialization
    void Start()
    {
        GameObject coreObj = GameObject.FindWithTag("ll");
        score = coreObj.GetComponent<Score>();
        score.score1 = 0;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
