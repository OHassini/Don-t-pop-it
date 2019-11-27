using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartManager : MonoBehaviour {
    public Text last, best;
	// Use this for initialization
	void Start () {
        Invoke("Spaun", 0.9f);
	}
	void Spaun()
    {
        last.gameObject.SetActive(true);
        best.gameObject.SetActive(true);
    }
	
}
