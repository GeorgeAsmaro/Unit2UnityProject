using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBlue : MonoBehaviour
{
    bool colorBlue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        getResults();

        if(colorBlue)
        {
            //Debug.Log("Color is blue");
        }
        
    }

    public bool setResults(bool trueOrFalse)
    {
        return colorBlue = trueOrFalse;
    }

    public bool getResults()
    {
        return colorBlue;
    }
}
