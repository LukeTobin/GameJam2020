using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [Header("Show UI")]
    public Text moneyUI;
    public Image current;

    [Header("Variables")]
    public float money;
    public bool plantPlant;
    public int playerLvl = 1;

    [Header("Stored")]
    public Image hover;
    public GameObject stored;

    void Start()
    {
        money = 100f;
    }

    void Update()
    {
        moneyUI.text = "" + money;

        if(stored != null)
        {
            plantPlant = true;
        }
    }

    public void UpdateStored(Sprite passed)
    {
        current.sprite = passed;
    }
}
