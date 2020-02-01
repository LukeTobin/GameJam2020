using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantChoice : MonoBehaviour
{

    [SerializeField] GameObject plant;
    Image focus;
    public GameManager gameCtrl;
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(MakeChoice);
        focus = GameObject.FindGameObjectWithTag("Focus").GetComponent<Image>();
        gameCtrl = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }


    void MakeChoice()
    {
        GameObject.FindGameObjectWithTag("Sidebar").SetActive(false);
        focus.enabled = false;
        gameCtrl.stored = plant;
        gameCtrl.plantPlant = true;
    }


}
