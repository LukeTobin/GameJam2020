using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideBar : MonoBehaviour
{

    [SerializeField] Image focusBG;

    private void Start()
    {
        focusBG.enabled = false;
        gameObject.SetActive(false);
    }

    public void MoveInMenu()
    {
        gameObject.SetActive(true);
        focusBG.enabled = true;
    }
}
