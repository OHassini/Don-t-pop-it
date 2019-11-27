using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class This : MonoBehaviour {

    private Score score;
    void Start()
    {
        GameObject coreObj = GameObject.FindWithTag("ll");
        if (coreObj != null)
        {
            score = coreObj.GetComponent<Score>();

            this.GetComponent<TextMeshProUGUI>().text = score.score1.ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
