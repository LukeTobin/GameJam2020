using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantChoice : MonoBehaviour
{
    //Plant arrays
    public List<GameObject> plants;
    public List<GameObject> plantsAvailable;

    //References
    [SerializeField] GameObject gameCtrl;

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
        for (int i = 0; i < plants.Count; i++)
        {
            var plantScript = plants[i].GetComponent<Plant>();

            if (plantScript.lvlReq <= currentLvl)
            {
                plantsAvailable.Add(plants[i]);
            }
        }
    }
}
