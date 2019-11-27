using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Start_manager : MonoBehaviour
{
    public TextMeshProUGUI game;
    public GameObject b1, b2, b3;
    private void Start()
    {


        Invoke("Setup", 0.5f);
        Invoke("First", 0.9f);
        Invoke("Secound", 1.3f);
        
        
       
        

    }
    void Setup()
    {
        game.gameObject.SetActive(true);
        b1.gameObject.SetActive(true);
        
    }
    void First()
    {
        b2.gameObject.SetActive(true);


    }
    void Secound()
    {
        b3.gameObject.SetActive(true);
    }
}
