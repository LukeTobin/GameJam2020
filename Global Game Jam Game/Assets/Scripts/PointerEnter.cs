using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerEnter : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    /*
     * Mouse enters object.
     */

    SideBar sb;

    void Start()
    {
        sb = GameObject.FindGameObjectWithTag("Sidebar").GetComponent<SideBar>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        sb.infobox.SetActive(true);
        sb.infobox.transform.position = new Vector2(transform.position.x - 130, transform.position.y);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        sb.infobox.SetActive(false);
    }
}
