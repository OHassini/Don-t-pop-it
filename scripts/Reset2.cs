using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset2 : MonoBehaviour
{
    private Score2 score;

    // Use this for initialization
    void Start()
    {
        GameObject coreObj = GameObject.FindWithTag("test");
        score = coreObj.GetComponent<Score2>();
        score.score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
