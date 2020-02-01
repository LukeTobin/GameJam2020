using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [Header("Show UI")]
    public Text moneyUI;

    [Header("Variables")]
    public float money;
    public bool plantPlant;

    [Header("Stored")]
    public GameObject stored;

    void Start()
    {

    }

    void Update()
    {
        moneyUI.text = "" + money;
    }
}
