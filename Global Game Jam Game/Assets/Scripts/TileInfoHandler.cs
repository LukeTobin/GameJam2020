using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileInfoHandler : MonoBehaviour
{

    public bool isOccupied;
    Button myBtn;
    GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        myBtn = GetComponent<Button>();

        myBtn.onClick.AddListener(PlacePlant);
    }

    void PlacePlant()
    {
        if (gm.stored != null && !isOccupied)
        {
            Debug.Log("can be planted");

            if(gm.money >= gm.stored.GetComponent<Plant>().buyCost)
            {
                GameObject newPlant = Instantiate(gm.stored);
                newPlant.transform.parent = gameObject.transform;
                newPlant.transform.position = transform.position;
                gm.money -= GetComponentInChildren<Plant>().buyCost;
                isOccupied = true;
            }
        }
        else if(isOccupied)
        {
            Debug.Log("occupied");
        }

        if (isOccupied)
        {
            if (GetComponentInChildren<Plant>().isReady)
            {
                GetComponentInChildren<Plant>().Harvest();
                isOccupied = false;
            }
            else
            {
                Debug.Log("not ready");
            }
            
        }
    }
}
