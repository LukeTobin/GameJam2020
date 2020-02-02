using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantChoice : MonoBehaviour
{
    //Plant lists
    public List<GameObject> plants;
    public List<GameObject> plantsAvailable;

    //References
    [SerializeField] GameObject gameCtrl;
    [SerializeField] Image menuItem;
    [SerializeField] Text menuCost;
    [SerializeField] RectTransform origin;
    GameManager gm;

    //Variables
    int currentLvl;



    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        currentLvl = gm.playerLvl;
    }

    public void FillMenu()
    {
        int xCount = 0;
        int yCount = 0;
        currentLvl = gm.playerLvl;

        for (int i = 0; i < plants.Count; i++)
        {
            var plantScript = plants[i].GetComponent<Plant>();

            if (plantScript.lvlReq <= currentLvl)
            {
                xCount++;

                if(xCount%6 == 0)
                {
                    yCount++;
                    xCount = 1;
                }

               // plantsAvailable.Add(plants[i]); //TODO: Add relevant information from prefab/procedurally generated GameObject
                menuItem.sprite = plants[i].GetComponent<Plant>().grown;
                menuItem.GetComponent<ReadyPlacement>().storing = plants[i];
                menuCost.text = "uwus: " + plants[i].GetComponent<Plant>().buyCost;
                Instantiate(menuItem, new Vector3(origin.localPosition.x + ((136 * xCount)- 20), origin.localPosition.y - 136 * yCount, origin.localPosition.z), Quaternion.identity, transform.parent = gameObject.transform);
                Instantiate(menuCost, new Vector3(origin.localPosition.x + ((136 * xCount) - 20), (origin.localPosition.y - 136 * yCount) - 60, origin.localPosition.z), Quaternion.identity, transform.parent = gameObject.transform);
                
            }
        }
    }
}
