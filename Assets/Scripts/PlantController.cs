using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    public Sprite noPlantObject;
    public Sprite weeds;
    public Sprite sunflower1;
    public Sprite sunflower2;

    public Sprite potato1;
    public Sprite potato2;

    public Sprite carrot1;
    public Sprite carrot2;

    public Sprite tomato1;
    public Sprite tomato2;


    public bool seedClicked = false;
    public string currentSeed;
    

    public float growTime = 0;

    public Transform plotObj;

    public bool water = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSeed != "")
        {
            Debug.Log(currentSeed);
            growTime += Time.deltaTime;
        }

        if(growTime > 5 && !water)
        {
            currentSeed = "";
            growTime = 0;
            GetComponent<SpriteRenderer>().sprite = weeds;

        }
        if(growTime > 5 && water)
        {
            if(currentSeed == "sunflower")
            {
                GetComponent<SpriteRenderer>().sprite = sunflower2;
            }
            if (currentSeed == "carrot")
            {
                GetComponent<SpriteRenderer>().sprite = carrot2;
            }
            if (currentSeed == "potato")
            {
                GetComponent<SpriteRenderer>().sprite = potato2;
            }
            if (currentSeed == "tomato")
            {
                GetComponent<SpriteRenderer>().sprite = tomato2;
            }

            growTime = 0;
            currentSeed = "";
        }
        
    }
     void OnMouseDown()
    {
        Debug.Log("Plant Clicked");
        if(GMScript.currentTool == "scythe")
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = noPlantObject;
        }

        if (GMScript.currentTool == "sunflower" && GetComponent<SpriteRenderer>().sprite == noPlantObject)
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = sunflower1;
            currentSeed = "sunflower";
            seedClicked = true;
            Debug.Log(currentSeed);

        }

        if (GMScript.currentTool == "carrot" && GetComponent<SpriteRenderer>().sprite == noPlantObject)
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = carrot1;
            currentSeed = "carrot";
            seedClicked = true;
            Debug.Log(currentSeed);
        }

        if (GMScript.currentTool == "potato" && GetComponent<SpriteRenderer>().sprite == noPlantObject)
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = potato1;
            currentSeed = "potato";
            seedClicked = true;
            Debug.Log(currentSeed);
        }

        if (GMScript.currentTool == "tomato" && GetComponent<SpriteRenderer>().sprite == noPlantObject)
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = tomato1;
            currentSeed = "tomato";
            seedClicked = true;
            Debug.Log(currentSeed);
        }


        if (GMScript.currentTool == "bucket" && GetComponent<SpriteRenderer>().sprite != noPlantObject)
        {
            //Destroy(gameObject);
            //Plant Watered
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
            
            water = true;
            
        }
    }
}
