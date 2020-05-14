using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools: MonoBehaviour
{
    public Transform cusorObj;

    public Transform seedSelectObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "scythe")
        {
            GMScript.currentTool = "scythe";
        }

        if (gameObject.name == "seeds")
        {
            GMScript.currentTool = "seeds";
            seedSelectObj.transform.position = new Vector2(7, -3);
        }

        if (gameObject.name == "bucket")
        {
            GMScript.currentTool = "bucket";
        }

        cusorObj.transform.position = transform.position; 
        Debug.Log(GMScript.currentTool);
    }
}
