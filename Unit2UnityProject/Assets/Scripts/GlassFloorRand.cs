using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFloorRand : MonoBehaviour
{

    int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(1, 2);
    }

    // Update is called once per frame
    public bool destroyThis()
    {
        if(rand == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
