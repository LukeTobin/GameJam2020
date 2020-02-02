using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideBar : MonoBehaviour
{
    [SerializeField] Image focusBG;

    public GameObject plantMenu, toolMenu, infobox;
    public Button exit;

    public Text title;
    public Text desc;
    public Text cost;

    private void Start()
    {
        focusBG.enabled = false;
        plantMenu.SetActive(false);
        toolMenu.SetActive(false);
        infobox.SetActive(false);
        gameObject.SetActive(false);

        exit.onClick.AddListener(closeAll);
    }

    public void MoveInMenu()
    {
        gameObject.SetActive(true);
        plantMenu.SetActive(true);
        focusBG.enabled = true;
    }

    public void closeAll()
    {
        focusBG.enabled = false;
        plantMenu.SetActive(false);
        toolMenu.SetActive(false);
        infobox.SetActive(false);
        gameObject.SetActive(false);
    }
}
