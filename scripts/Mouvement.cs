using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour {


    
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            Vector2 pos = Input.GetTouch(0).position;
            Vector2 pos2 = Camera.current.ScreenToWorldPoint(pos);
            transform.position = pos2;
        }


        
        



    }
}
