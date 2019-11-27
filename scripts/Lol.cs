using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lol : MonoBehaviour {

    public TextMeshProUGUI MoneyAmount;
   
	
	// Update is called once per frame
	void Update ()
    {
        MoneyAmount.text = PlayerPrefs.GetInt("Money").ToString();

    }
}
