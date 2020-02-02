using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Image box;
    TileInfoHandler tih;

    void Start()
    {
        box = GetComponent<Image>();
        tih = GetComponent<TileInfoHandler>();
        box.color = new Color(255, 255, 255, 0);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!tih.isOccupied)
        {
            box.color = new Color(255, 255, 255, 180);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        box.color = new Color(255, 255, 255, 0);
    }
}
