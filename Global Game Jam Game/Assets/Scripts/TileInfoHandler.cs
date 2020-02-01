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
        if (gm.plantPlant)
        {
            Debug.Log("can be planted");

            GameObject newPlant = Instantiate(gm.stored);
            newPlant.transform.parent = gameObject.transform;
            newPlant.transform.position = transform.position;
            isOccupied = true;
            gm.plantPlant = false;
        }
        else if(!isOccupied)
        {
            Debug.Log("cant plant yet");
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
