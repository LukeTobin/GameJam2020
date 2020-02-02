using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uwuMachine : MonoBehaviour
{

    public Text upgrade;
    GameManager gm;

    int upgradeCosts;

    public Sprite[] uwum;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        upgradeCosts = 30;
    }

    public void Upgrade()
    {
        if(gm.money >= (gm.playerLvl * 2))
        {
            gm.money -= gm.playerLvl * 2;
            upgradeCosts -= gm.playerLvl * 2;

            if (upgradeCosts <= 0)
            {
                gm.playerLvl++;
                upgradeCosts = 30 * gm.playerLvl;

                gameObject.GetComponent<Image>().sprite = uwum[gm.playerLvl];
            }
        }
    }
    
}
