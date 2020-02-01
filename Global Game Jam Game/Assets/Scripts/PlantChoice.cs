using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantChoice : MonoBehaviour
{

    [SerializeField] GameObject plant;
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(MakeChoice);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeChoice()
    {

    }


}
