using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs_Manger : MonoBehaviour {

    public GameObject[] Prefabs;
    private Vector2 pos;
	void Start () {
        pos = new Vector2(0, -2.6f);
        if (PlayerPrefs.GetInt("n", 0) == 0)
        {
            Instantiate(Prefabs[5], pos, Quaternion.identity);
        }
        else
        {
            Debug.Log(PlayerPrefs.GetInt("n", 0).ToString());
            Instantiate(Prefabs[PlayerPrefs.GetInt("n", 0)], pos, Quaternion.identity);
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
