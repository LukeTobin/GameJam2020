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

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        sb = GameObject.FindGameObjectWithTag("Sidebar").GetComponent<SideBar>();
    }
 
    public void purchaseMe()
    {
        gm.stored = storing;
        gm.money -= storing.GetComponent<Plant>().buyCost;
        gm.UpdateStored(storing.GetComponent<Plant>().grown);
        sb.closeAll();
    }
}
