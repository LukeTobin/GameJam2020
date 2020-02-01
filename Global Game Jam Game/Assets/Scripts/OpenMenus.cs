using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenus : MonoBehaviour
{
    SideBar sb;

    void Start()
    {
        sb = GetComponentInParent<SideBar>();
    }

    public void OpenPlants()
    {
        sb.plantMenu.SetActive(true);
        sb.toolMenu.SetActive(false);
    }

    public void OpenTools()
    {
        sb.plantMenu.SetActive(false);
        sb.toolMenu.SetActive(true);
    }

}
