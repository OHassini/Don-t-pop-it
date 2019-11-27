using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ShopButtonManager : MonoBehaviour {

    public int n;
    public int Objectnum;
    public Button[] Play;
    public Button[] Buy;
    public TextMeshProUGUI[] price;
    public int[] flouss;
    private int moneyAfter;
    private int money;
    public GameObject pannel;
    
    private void Start()
    {
      if(PlayerPrefs.GetInt("axe",0)== 1)
        {
            Buy[1].gameObject.SetActive(false);
            Play[1].gameObject.SetActive(true);
            price[1].gameObject.SetActive(false);
        }
      if(PlayerPrefs.GetInt("Batman")== 1)
        {
            Buy[2].gameObject.SetActive(false);
            Play[2].gameObject.SetActive(true);
            price[2].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Bee") == 1)
        {
            Buy[3].gameObject.SetActive(false);
            Play[3].gameObject.SetActive(true);
            price[3].gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Cactus")== 1)
        {
            Buy[4].gameObject.SetActive(false);
            Play[4].gameObject.SetActive(true);
            price[4].gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Dart")== 1)
        {
            Buy[6].gameObject.SetActive(false);
            Play[6].gameObject.SetActive(true);
            price[6].gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Fork")== 1)
        {
            Buy[7].gameObject.SetActive(false);
            Play[7].gameObject.SetActive(true);
            price[7].gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Mismar") == 1)
        {
            Buy[8].gameObject.SetActive(false);
            Play[8].gameObject.SetActive(true);
            price[8].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Garden") == 1)
        {
            Buy[9].gameObject.SetActive(false);
            Play[9].gameObject.SetActive(true);
            price[9].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Knife") == 1)
        {
            Buy[10].gameObject.SetActive(false);
            Play[10].gameObject.SetActive(true);
            price[10].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Guitar") == 1)
        {
            Buy[11].gameObject.SetActive(false);
            Play[11].gameObject.SetActive(true);
            price[11].gameObject.SetActive(false);
        }
        if(PlayerPrefs.GetInt("Scissors")== 1)
        {
            Buy[12].gameObject.SetActive(false);
            Play[12].gameObject.SetActive(true);
            price[12].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Shuriken") == 1)
        {
            Buy[13].gameObject.SetActive(false);
            Play[13].gameObject.SetActive(true);
            price[13].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Saw") == 1)
        {
            Buy[14].gameObject.SetActive(false);
            Play[14].gameObject.SetActive(true);
            price[14].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Shield") == 1)
        {
            Buy[16].gameObject.SetActive(false);
            Play[16].gameObject.SetActive(true);
            price[16].gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("King") == 1)
        {
            Buy[15].gameObject.SetActive(false);
            Play[15].gameObject.SetActive(true);
            price[15].gameObject.SetActive(false);
        }

    }
    public void Update()
    {
        Objectnum = n;
        PlayerPrefs.SetInt("n",Objectnum);
       

    }
    public void Axe()
    {
        n = 1;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("axe", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Batman()
    {
        n = 2;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Batman", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Bee()
    {
        n = 3;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Bee", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Cactus()
    {
        n = 4;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Cactus", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Chouka()
    {
        n = 5;
        Objectnum = n;

    }
    public void Dart()
    {
        n = 6;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Dart", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Fork()
    {
        n = 7;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Fork", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Mismar()
    {
        n = 8;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Mismar", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Garden()
    {
        n = 9;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Garden", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }

    }
    public void Knife()
    {
        n = 10;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Knife", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Guitar()
    {
        n = 11;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Guitar", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Scissors()
    {
        n = 12;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Scissors", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Shuriken()
    {
        n = 13;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Shuriken", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Saw()
    {
        n = 14;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Saw", 1);
            price[n].gameObject.SetActive(false);

        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void King()
    {
        n = 15;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("King", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void Shield()
    {
        n = 16;
        if (PlayerPrefs.GetInt("Money", 0) >= flouss[n])
        {
            Objectnum = n;
            Buy[n].gameObject.SetActive(false);
            Play[n].gameObject.SetActive(true);
            money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("Shield", 1);
            price[n].gameObject.SetActive(false);
        }
        else
        {
            pannel.gameObject.SetActive(true);
        }
    }
    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");

    }
   public void BuyButton()
    {
        money = PlayerPrefs.GetInt("Money", 0) - flouss[n];
        PlayerPrefs.SetInt("Money",money);
    }

    public void Axeplay()
    {
        n = 1;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void BatmanPlay()
    {
        n = 2;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Beeplay()
    {
        n = 3;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Cactusplay()
    {
        n = 4;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");

    }
    public void Choukaplay()
    {
        n = 5;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void DartPLay()
    {
        n = 6;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Forkplay()
    {
        n = 7;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Mismarplay()
    {
        n = 8;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Gardenplay()
    {
        n = 9;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");

    }
    public void Knifeplay()
    {
        n = 10;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Guitarplay()
    {
        n = 11;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Scissorsplay()
    {
        n = 12;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void ShurikenPlay()
    {
        n = 13;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Sawplay()
    {
        n = 14;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Kingplay()
    {
        n = 15;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Shieldplay()
    {
        n = 16;
        if (PlayerPrefs.GetInt("Reverse") == 0)
            SceneManager.LoadScene("I willl choose the name later");
        else if (PlayerPrefs.GetInt("Reverse") == 1)
            SceneManager.LoadScene("I willl choose the name later 1");
    }
    public void Close()
    {
        pannel.gameObject.SetActive(false);
    }
}
