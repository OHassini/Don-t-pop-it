using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
	}
	
	// Update is called once per frame
	
}
