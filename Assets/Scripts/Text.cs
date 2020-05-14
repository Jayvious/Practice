using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "SunflowerTxt")
        {
            GetComponent<TextMesh>().text = "Sunflower Seeds : " + GMScript.sunflowerSeeds;
        }

        if (gameObject.name == "CarrotTxt")
        {
            GetComponent<TextMesh>().text = "Carrot Seeds : " + GMScript.carrotSeeds;
        }

        if (gameObject.name == "PotatoTxt")
        {
            GetComponent<TextMesh>().text = "Potato Seeds : " + GMScript.potatoSeeds;
        }

        if (gameObject.name == "TomatoTxt")
        {
            GetComponent<TextMesh>().text = "Tomato Seeds : " + GMScript.tomatoSeeds;
        }

    }

     void OnMouseDown()
    {
        if (gameObject.name == "SunflowerTxt")
        {
            GMScript.currentTool = "sunflower";
         }

        if (gameObject.name == "CarrotTxt")
        {
            GMScript.currentTool = "carrot";
        }

        if (gameObject.name == "PotatoTxt")
        {
            GMScript.currentTool = "potato";
        }

        if (gameObject.name == "TomatoTxt")
        {
            GMScript.currentTool = "tomato";
        }
    }
}
