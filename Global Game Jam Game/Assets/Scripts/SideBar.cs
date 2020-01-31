using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBar : MonoBehaviour
{
    private void Start()
    {
        MoveInMenu();
    }

    public void MoveInMenu()
    {
        gameObject.SetActive(true);
    }
}
