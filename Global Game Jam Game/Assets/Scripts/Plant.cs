﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{

    /*
     * Plant in garden
     * 
     */
    int level = 1;

    [Header("Images")]
    public Sprite seed;
    public Sprite child;
    public Sprite grown;

    [Header("Exceptions")]
    public bool fourth;
    public Sprite last;

    [Header("Values")]
    public float growTime;
    public float buyCost;
    public float sellCost;

    [Header("Accessable")]
    public string _name;
    public string _desc;
    public int lvlReq;
    float startTime;
    public bool isReady;

    GameManager gm;

    private void Start()
    {
        level = 1;
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        GetComponent<Image>().sprite = seed;
        startTime = growTime;
    }

    void Update()
    {
        if(growTime <= 0 && !isReady)
        {
            level++;
            Debug.Log(level);
            switch (level)
            {
                case 1:
                    Debug.Log("baby time");
                    GetComponent<Image>().sprite = seed;
                    break;
                case 2:
                    Debug.Log("oh yeah its child time");
                    GetComponent<Image>().sprite = child;
                    break;
                case 3:
                    Debug.Log("o yis it deth time");
                    if (!fourth)
                    {
                        isReady = true;
                    }
                    GetComponent<Image>().sprite = grown;
                    break;
                case 4:
                    Debug.Log("exception caught");
                    isReady = true;
                    GetComponent<Image>().sprite = last;
                    break;
                default:
                    GetComponent<Image>().sprite = null;
                    break;
            }

                startTime *= Random.Range(level - (level*3), level + (level*3));
                growTime = startTime;

        }
        else if(!isReady)
        {
            growTime -= Time.deltaTime;
        }
    }

    public void Harvest()
    {
        gm.money += sellCost;
        Debug.Log("UWU TIME!!");
        isReady = false;
        Destroy(gameObject);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isReady)
            {
                gm.money += sellCost;
                Debug.Log("UWU TIME!!");
                Destroy(gameObject);
            }
        }
    }
}
