using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadyPlacement : MonoBehaviour
{

    [SerializeField] GameObject plant;
    public GameObject storing;

    GameManager gm;
    SideBar sb;

    Image storedHover;

    public string _name, _desc;
    public float _cost;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        sb = GameObject.FindGameObjectWithTag("Sidebar").GetComponent<SideBar>();

        _name = storing.GetComponent<Plant>()._name;
        _desc = storing.GetComponent<Plant>()._desc;
        _cost = storing.GetComponent<Plant>().sellCost;

    }
 
    public void purchaseMe()
    {
        gm.stored = storing;
        gm.UpdateStored(storing.GetComponent<Plant>().grown);
        sb.closeAll();
    }
}
