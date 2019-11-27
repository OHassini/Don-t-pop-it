using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyToAddPosition : MonoBehaviour {



    public GameObject[] Monies;
    public int money;

    private void Update()
    
    {
        money = PlayerPrefs.GetInt("Money", 0);
       

           
            money = PlayerPrefs.GetInt("Money", 0);
        if(money < 10 )
        {
            Monies[5].gameObject.SetActive(true);
        }
            if (money >= 10 && money <100 )
            {
            Monies[0].gameObject.SetActive(true);
            }
            if (money >100 && money < 1000)
            {
            Monies[1].gameObject.SetActive(true);
        }
            if (money >= 1000 && money < 10000)
            {
            Monies[2].gameObject.SetActive(true);
        }
            if (money >= 10000 && money < 100000)
            {
            Monies[3].gameObject.SetActive(true);
        }
            if (money >= 100000)
            {
            Monies[4].gameObject.SetActive(true);
        }
        }
    }

    // Update is called once per frame
   

