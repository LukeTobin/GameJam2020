using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprinkler : MonoBehaviour
{
    float health;

    float timer, sprinkleTime = 4f;

    private void Start()
    {
        sprinkleTime = 4f;
        timer = sprinkleTime;
        Debug.Log("sprinkers setup");
    }

    private void Update()
    {
        if(timer <= 0)
        {
            Debug.Log("sprinkler ran.");

            GameObject[] holders = GameObject.FindGameObjectsWithTag("Holder");
            for (int i = 0; i < holders.Length; i++)
            {
                if (holders[i].GetComponent<TileInfoHandler>().isOccupied)
                {
                    holders[i].GetComponentInChildren<Plant>().growTime--;
                }
            }

            timer = sprinkleTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
