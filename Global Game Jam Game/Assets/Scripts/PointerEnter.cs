using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PointerEnter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /*
     * Mouse enters object.
     */

    SideBar sb;
    ReadyPlacement rp;

    void Start()
    {
        sb = GameObject.FindGameObjectWithTag("Sidebar").GetComponent<SideBar>();
        rp = GetComponent<ReadyPlacement>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        sb.infobox.SetActive(true);
        sb.infobox.transform.position = new Vector2(transform.position.x - 130, transform.position.y);

        sb.title.text = rp._name;
        sb.desc.text = rp._desc;
        sb.cost.text = "" + rp._cost;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        sb.infobox.SetActive(false);
    }
}
