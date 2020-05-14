using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static string currentTool = "none";
    public Transform grassObj;

    public static int sunflowerSeeds = 5;
    public static int potatoSeeds = 3;
    public static int tomatoSeeds = 8;
    public static int carrotSeeds = 4;

    void Start()
    {
        for(int xPos = -8; xPos < 10; xPos += 2)
        {
            for(int yPos = 5; yPos > -6; yPos -= 2)
            {
                Instantiate(grassObj, new Vector2(xPos, yPos), grassObj.rotation);
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
