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
    [SerializeField] RectTransform origin;

    //Variables
    int currentLvl;



    // Start is called before the first frame update
    void Start()
    {
        var gameManager = gameCtrl.GetComponent<GameManager>();
        currentLvl = gameManager.playerLvl;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FillMenu()
    {
        int xCount = 0;
        int yCount = 0;

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

                Debug.Log(xCount);
                plantsAvailable.Add(plants[i]); //TODO: Add relevant information from prefab/procedurally generated GameObject
                Instantiate(menuItem, new Vector3(origin.localPosition.x + ((136 * xCount)- 20), origin.localPosition.y - 136 * yCount, origin.localPosition.z), Quaternion.identity, transform.parent = gameObject.transform);
            }
        }
    }
}
